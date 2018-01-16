using Lua.Tokenizer.Evaluaters;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lua.Tokenizer
{
    public enum TokenType
    {
        Keyword,
        Whitespace,
        Identifier,
        Structural,
        Operator,
        String,
        Number,
        Boolean,
        Nil
    }

    public class Token
    {
        public TokenType Type { get; set; }
        public List<CharacterInfo> Characters { get; set; } = new List<CharacterInfo>();
        public string Source { get; set; }

        private static readonly Func<Evaluator>[] Evaluators = new Func<Evaluator>[]
        {
            () => new KeywordEvaluator(),
            () => new IdentifierEvaluator(),
            () => new BooleanEvaluator(),
            () => new NilEvaluator(),
        };

        public static IEnumerable<Token> Parse(IEnumerable<CharacterInfo> source)
        {
            var evaluators = Evaluators.Select(e => e());

            foreach (var character in source)
            {
                foreach (var evaluator in evaluators)
                    evaluator.Evaluate(character);
                var accepted = evaluators.SingleOrDefault(e => e.State == EvaluatorState.Accepted);
                if (accepted != null)
                {
                    yield return accepted.Value;
                    evaluators = Evaluators.Select(e => e());
                }
                else
                {
                    evaluators = evaluators.Where(e => e.State != EvaluatorState.Failed);
                }
            }

            var remaining = evaluators.SingleOrDefault(e => e.State == EvaluatorState.Accepted);
            if (remaining != null)
                yield return remaining.Value;
        }
    }
}

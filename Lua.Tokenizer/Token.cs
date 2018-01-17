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

    public partial class Token
    {
        public TokenType Type { get; set; }
        public List<CharacterInfo> Characters { get; set; } = new List<CharacterInfo>();
        public string Source { get; set; }
        public object Value { get; set; }

        private static readonly Func<Evaluator>[] Evaluators = new Func<Evaluator>[]
        {
            () => new KeywordEvaluator(),
            () => new IdentifierEvaluator(),
            () => new BooleanEvaluator(),
            () => new NilEvaluator(),
            () => new NumberEvaluator(),
            () => new StringEvaluator(),
            () => new OperatorEvaluator(),
            () => new StructuralPunctuationEvaluator(),
            () => new WhitespaceEvaluator(),
        };

        public static IEnumerable<Token> Parse(IEnumerable<CharacterInfo> source)
        {
            var evaluators = Evaluators.Select(e => e());
            foreach (var character in source)
            {
                // if there is exactly one accepted evaluator, grab it
                var accepted = evaluators.SingleOrDefault(e => e.State == EvaluatorState.Accepted);

                // step-forward all active evaluators
                foreach (var evaluator in evaluators)
                    evaluator.State = evaluator.Evaluate(character);

                // filter evaluators list
                evaluators = evaluators.Where(e => e.State != EvaluatorState.Failed).ToList();

                // if there are no evaluators remaining
                if (!evaluators.Any())
                {
                    // yield the last accepted value
                    if (accepted != null)
                        yield return accepted.Value;
                    else
                        //throw a fit
                        throw new LuaTokenizerException("There are no passing token evaluators for the given text");

                    //reset evaluators and re-send current character
                    evaluators = Evaluators.Select(e => e());
                    foreach (var evaluator in evaluators)
                        evaluator.State = evaluator.Evaluate(character);
                }
            }

            var remaining = evaluators.SingleOrDefault(e => e.State == EvaluatorState.Accepted);
            if (remaining != null)
                yield return remaining.Value;
        }
    }

}

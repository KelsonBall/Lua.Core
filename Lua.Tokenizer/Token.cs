using Lua.Common;
using Lua.Tokenizer.Evaluaters;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lua.Tokenizer
{
    public enum TokenType
    {
        None,
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
        public string Source { get; set; } = "";
        public object Value { get; set; }

        private static readonly Func<Evaluator> Delimeter = () => new WhitespaceEvaluator();

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

        public static IEnumerable<Token> Parse(IEnumerable<CharacterInfo> source, bool includeWhiteSpace = false)
        {
            if (includeWhiteSpace)
                return Evaluate(source);
            else
                return Evaluate(source).Where(t => t.Type != TokenType.Whitespace);
        }

        private static IEnumerable<Token> Evaluate(IEnumerable<CharacterInfo> source)
        {
            var evaluators = DefaultEvaluators();
            foreach (var character in source)
            {
                var next = StepEvaluators(evaluators, character);
                if (evaluators.HasSingle() && !next.Any())
                {
                    yield return evaluators.Single().Value;
                    evaluators = StepEvaluators(DefaultEvaluators(), character);
                }
                else if (!next.Any())
                {
                    var token = evaluators.Single(e => e.State == EvaluatorState.Accepted).Value;
                    token.Source = token.Source.Trim();
                    yield return token;
                    evaluators = StepEvaluators(DefaultEvaluators(), character);
                }
                else
                {
                    evaluators = next;
                }
            }
        }

        private static Evaluator AcceptedEvaluator(IEnumerable<Evaluator> evaluators)
        {
            if (evaluators.Any(e => e.State == EvaluatorState.Running))
                return null;
            return evaluators.Where(e => e.State == EvaluatorState.Accepted).ItemIfSingle();
        }

        private static IEnumerable<Evaluator> DefaultEvaluators() => Evaluators.Select(e => e());

        private static Evaluator[] StepEvaluators(IEnumerable<Evaluator> evaluators, CharacterInfo character)
        {
            return evaluators.Select(e =>
            {
                var n = e.Copy();
                n.State = n.Evaluate(character);
                return n;
            }).Where(e => e.State != EvaluatorState.Failed)
              .ToArray();
        }

        public override string ToString()
        {
            return $"[\"{Source}\", {Type}]";
        }

        public Token Copy() => new Token
        {
            Characters = new List<CharacterInfo>(Characters.Select(c => new CharacterInfo { Column = c.Column, Offset = c.Offset, Row = c.Row, Value = c.Value })),
            Source = Source,
            Type = Type,
            Value = Value,
        };
    }

}

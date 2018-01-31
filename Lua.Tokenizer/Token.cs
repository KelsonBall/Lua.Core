using Lua.Common;
using Lua.Tokenizer.Evaluaters;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lua.Tokenizer
{
    public partial class Token
    {
        public TokenType Type { get; set; }
        public List<CharacterInfo> Characters { get; set; } = new List<CharacterInfo>();
        public string Source { get; set; } = "";
        public object Value { get; set; }

        private static readonly Func<Evaluator<CharacterInfo, Token>>[] Evaluators =
            new Func<Evaluator<CharacterInfo, Token>>[]
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
                return new EvaluationMachine<CharacterInfo, Token>(Evaluators, source);
            else
                return new EvaluationMachine<CharacterInfo, Token>(Evaluators, source).Where(t => t.Type != TokenType.Whitespace);
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

﻿using System.Linq;

namespace Lua.Tokenizer.Evaluaters
{
    public class WhitespaceEvaluator : Evaluator
    {
        public WhitespaceEvaluator()
        {
            Value.Type = TokenType.Whitespace;
        }

        public override Evaluator Copy()
        {
            return new WhitespaceEvaluator
            {
                Value = Value.Copy(),
                State = State
            };
        }

        public override EvaluatorState Evaluate(CharacterInfo info)
        {
            base.Evaluate(info);
            if (Token.WhitespaceChars.Any(c => c.ToString() == info.Value))
                return EvaluatorState.Accepted;
            return EvaluatorState.Failed;
        }
    }
}

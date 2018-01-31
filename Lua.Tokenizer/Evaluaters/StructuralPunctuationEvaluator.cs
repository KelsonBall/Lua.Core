using Lua.Common;
using System.Linq;

namespace Lua.Tokenizer.Evaluaters
{
    public class StructuralPunctuationEvaluator : TokenEvaluator
    {
        public StructuralPunctuationEvaluator()
        {
            Value.Type = TokenType.Structural;
        }

        public override Evaluator<CharacterInfo, Token> Copy()
        {
            return new StructuralPunctuationEvaluator
            {
                State = State,
                Value = Value.Copy()
            };
        }

        public override EvaluatorState Evaluate(CharacterInfo info)
        {
            base.Evaluate(info);
            if (Token.StructuralPunctuation.Contains(Value.Source))
                return EvaluatorState.Accepted;
            if (Token.StructuralPunctuation.Any(s => s.StartsWith(Value.Source)))
                return EvaluatorState.Running;
            return EvaluatorState.Failed;
        }
    }
}

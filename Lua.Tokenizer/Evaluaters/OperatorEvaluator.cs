using Lua.Common;
using System.Linq;

namespace Lua.Tokenizer.Evaluaters
{
    public class OperatorEvaluator : TokenEvaluator
    {
        public OperatorEvaluator()
        {
            Value.Type = TokenType.Operator;
        }

        public override Evaluator<CharacterInfo, Token> Copy()
        {
            return new OperatorEvaluator
            {
                State = State,
                Value = Value.Copy()
            };
        }

        public override EvaluatorState Evaluate(CharacterInfo info)
        {
            base.Evaluate(info);
            if (Token.Operators.Contains(Value.Source))
                return EvaluatorState.Accepted;
            if (Token.Operators.Any(s => s.StartsWith(Value.Source)))
                return EvaluatorState.Running;
            return EvaluatorState.Failed;
        }
    }
}

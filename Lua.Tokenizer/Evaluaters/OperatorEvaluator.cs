using System.Linq;

namespace Lua.Tokenizer.Evaluaters
{
    public class OperatorEvaluator : Evaluator
    {
        public OperatorEvaluator()
        {
            Value.Type = TokenType.Operator;
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

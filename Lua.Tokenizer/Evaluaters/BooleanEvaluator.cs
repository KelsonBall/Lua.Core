using Lua.Common;

namespace Lua.Tokenizer.Evaluaters
{
    public class BooleanEvaluator : TokenEvaluator
    {
        public BooleanEvaluator()
        {
            Value.Type = TokenType.Boolean;
        }

        public override Evaluator<CharacterInfo, Token> Copy()
        {
            return new BooleanEvaluator
            {
                State = State,
                Value = Value.Copy()
            };
        }

        public override EvaluatorState Evaluate(CharacterInfo info)
        {
            base.Evaluate(info);
            if (Value.Source == "false")
            {
                Value.Value = false;
                return EvaluatorState.Accepted;
            }
            if (Value.Source == "true")
            {
                Value.Value = true;
                return EvaluatorState.Accepted;
            }
            if ("true".StartsWith(Value.Source) || "false".StartsWith(Value.Source))
                return EvaluatorState.Running;
            return EvaluatorState.Failed;
        }
    }
}

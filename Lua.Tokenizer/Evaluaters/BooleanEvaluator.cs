namespace Lua.Tokenizer.Evaluaters
{
    public class BooleanEvaluator : Evaluator
    {
        public BooleanEvaluator()
        {
            Value.Type = TokenType.Boolean;
        }

        public override Evaluator Copy()
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
                return EvaluatorState.Accepted;
            if (Value.Source == "true")
                return EvaluatorState.Accepted;
            if ("true".StartsWith(Value.Source) || "false".StartsWith(Value.Source))
                return EvaluatorState.Running;
            return EvaluatorState.Failed;
        }
    }
}

namespace Lua.Tokenizer.Evaluaters
{
    public class NilEvaluator : Evaluator
    {
        public NilEvaluator()
        {
            Value.Type = TokenType.Nil;
        }

        public override EvaluatorState Evaluate(CharacterInfo info)
        {
            base.Evaluate(info);
            if (Value.Source == "nil")
                return EvaluatorState.Accepted;
            if ("nil".StartsWith(Value.Source))
                return EvaluatorState.Running;
            return EvaluatorState.Failed;
        }
    }
}

using Lua.Common;

namespace Lua.Tokenizer.Evaluaters
{
    public class NilEvaluator : TokenEvaluator
    {
        public NilEvaluator()
        {
            Value.Type = TokenType.Nil;
        }

        public override Evaluator<CharacterInfo, Token> Copy()
        {
            return new NilEvaluator
            {
                State = State,
                Value = Value.Copy()
            };
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

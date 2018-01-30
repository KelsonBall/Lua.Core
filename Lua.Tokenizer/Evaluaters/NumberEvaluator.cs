using System.Linq;

namespace Lua.Tokenizer.Evaluaters
{
    public class NumberEvaluator : Evaluator
    {
        public NumberEvaluator()
        {
            Value.Type = TokenType.Number;
        }

        public override Evaluator Copy()
        {
            return new NumberEvaluator
            {
                Value = Value.Copy(),
                State = State
            };
        }

        public override EvaluatorState Evaluate(CharacterInfo info)
        {
            base.Evaluate(info);

            if (Token.Digits().Contains(info.Value))
                return EvaluatorState.Accepted;
            else if (info.Value == ".")
            {
                if (Value.Source.Contains("."))
                    return EvaluatorState.Failed;
                return EvaluatorState.Running;
            }
            return EvaluatorState.Failed;
        }
    }
}

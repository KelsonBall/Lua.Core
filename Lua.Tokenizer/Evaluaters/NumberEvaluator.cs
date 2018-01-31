using Lua.Common;
using System.Linq;

namespace Lua.Tokenizer.Evaluaters
{
    public class NumberEvaluator : TokenEvaluator
    {
        public NumberEvaluator()
        {
            Value.Type = TokenType.Number;
        }

        public override Evaluator<CharacterInfo, Token> Copy()
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
            {
                if (int.TryParse(Value.Source, out int integer))
                    Value.Value = integer;
                else if (double.TryParse(Value.Source, out double floating))
                    Value.Value = floating;
                return EvaluatorState.Accepted;
            }
            else if (info.Value == ".")
            {
                if (Value.Source.Count(c => c == '.') > 1)
                    return EvaluatorState.Failed;
                return EvaluatorState.Running;
            }
            return EvaluatorState.Failed;
        }
    }
}

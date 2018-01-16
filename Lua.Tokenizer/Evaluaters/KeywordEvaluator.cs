using System.Linq;
using System.Text;

namespace Lua.Tokenizer.Evaluaters
{
    public class KeywordEvaluator : Evaluator
    {
        public KeywordEvaluator()
        {
            Value.Type = TokenType.Keyword;
        }

        public override EvaluatorState Evaluate(CharacterInfo info)
        {
            base.Evaluate(info);
            if (TokenData.Keyword.Contains(Value.Source))
                return EvaluatorState.Accepted;
            return EvaluatorState.Running;
        }
    }

    public class BooleanEvaluator : Evaluator
    {
        public BooleanEvaluator()
        {
            Value.Type = TokenType.Boolean;
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

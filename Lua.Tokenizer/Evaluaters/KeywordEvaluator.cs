using System.Linq;

namespace Lua.Tokenizer.Evaluaters
{
    public class KeywordEvaluator : Evaluator
    {
        public KeywordEvaluator()
        {
            Value.Type = TokenType.Keyword;
        }

        public override Evaluator Copy()
        {
            return new KeywordEvaluator
            {
                Value = Value.Copy(),
                State = State
            };
        }

        public override EvaluatorState Evaluate(CharacterInfo info)
        {
            base.Evaluate(info);
            if (Token.Keywords.Contains(Value.Source))
                return EvaluatorState.Accepted;
            if (!Token.Keywords.Any(k => k.StartsWith(Value.Source)))
                return EvaluatorState.Failed;
            return EvaluatorState.Running;
        }
    }
}

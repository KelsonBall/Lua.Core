using System.Linq;

namespace Lua.Tokenizer.Evaluaters
{
    public class WhitespaceEvaluator : Evaluator
    {
        public WhitespaceEvaluator()
        {
            Value.Type = TokenType.Whitespace;
        }

        public override EvaluatorState Evaluate(CharacterInfo info)
        {
            base.Evaluate(info);
            if (Value.Source.Any(c => Token.WhitespaceChars.Contains(c)))
                return EvaluatorState.Failed;
            return EvaluatorState.Accepted;
        }
    }
}

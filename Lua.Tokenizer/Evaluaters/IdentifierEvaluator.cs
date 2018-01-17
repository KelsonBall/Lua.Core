using System.Linq;

namespace Lua.Tokenizer.Evaluaters
{
    public class IdentifierEvaluator : Evaluator
    {
        public IdentifierEvaluator()
        {
            Value.Type = TokenType.Keyword;
        }

        public override EvaluatorState Evaluate(CharacterInfo info)
        {
            base.Evaluate(info);
            if (!Token.IdentifierCharacters.Contains(info.Value))
                return EvaluatorState.Failed;

            if (!Token.ReservedWords.Contains(Value.Source))
                return EvaluatorState.Accepted;

            return EvaluatorState.Running;
        }
    }
}

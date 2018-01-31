using Lua.Common;
using System.Linq;

namespace Lua.Tokenizer.Evaluaters
{
    public class IdentifierEvaluator : TokenEvaluator
    {
        public IdentifierEvaluator()
        {
            Value.Type = TokenType.Identifier;
        }

        public override Evaluator<CharacterInfo, Token> Copy()
        {
            return new IdentifierEvaluator
            {
                Value = Value.Copy(),
                State = State
            };
        }

        public override EvaluatorState Evaluate(CharacterInfo info)
        {
            base.Evaluate(info);
            if (!Token.IdentifierCharacters.Contains(info.Value))
                return EvaluatorState.Failed;

            if (Token.ReservedWords.Contains(Value.Source))
                return EvaluatorState.Running;

            return EvaluatorState.Accepted;
        }
    }
}

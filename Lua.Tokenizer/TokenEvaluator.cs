using Lua.Common;

namespace Lua.Tokenizer
{
    public abstract class TokenEvaluator : Evaluator<CharacterInfo, Token>
    {
        public TokenEvaluator()
        {
            Value = new Token();
        }

        public override EvaluatorState Evaluate(CharacterInfo info)
        {
            Value.Source += info.Value;
            Value.Characters.Add(info);
            return State;
        }
    }
}

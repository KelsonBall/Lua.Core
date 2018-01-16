namespace Lua.Tokenizer.Evaluaters
{
    public abstract class Evaluator
    {
        public EvaluatorState State { get; set; }
        public Token Value { get; set; }

        public virtual EvaluatorState Evaluate(CharacterInfo info)
        {
            Value.Source += info.Value;
            Value.Characters.Add(info);
            return State;
        }
    }
}

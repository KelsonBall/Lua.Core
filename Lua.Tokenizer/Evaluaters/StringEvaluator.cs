using System.Text;

namespace Lua.Tokenizer.Evaluaters
{
    public class StringEvaluator : Evaluator
    {
        private StringBuilder source = new StringBuilder();
        private string stringStarter;
        private bool multiCharacterStarterRecieved = false;
        private bool escaped = false;
        private bool completed = false;

        public StringEvaluator()
        {
            Value.Type = TokenType.String;
        }

        public override EvaluatorState Evaluate(CharacterInfo info)
        {
            if (completed)
                return EvaluatorState.Failed;

            base.Evaluate(info);
            if (stringStarter == null)
            {
                if (info.Value == "'")
                    stringStarter = "'";
                if (info.Value == "\"")
                    stringStarter = "\"";
                if (info.Value == "[")
                    stringStarter = "[";
                else
                    return EvaluatorState.Failed;
                return EvaluatorState.Running;
            }

            if (stringStarter == "[")
            {
                if (info.Value == "[")
                    stringStarter = "]]";
                else
                    return EvaluatorState.Failed;
                return EvaluatorState.Running;
            }

            if (info.Value == @"\")
            {
                if (escaped)
                {
                    source.Append(@"\");
                    escaped = false;
                    return EvaluatorState.Running;
                }
                else
                {
                    escaped = true;
                    return EvaluatorState.Running;
                }
            }

            if (escaped)
            {
                switch (info.Value)
                {
                    case "t":
                        source.Append("\t");
                        escaped = false;
                        return EvaluatorState.Running;
                    case "r":
                        source.Append("\r");
                        escaped = false;
                        return EvaluatorState.Running;
                    case "n":
                        source.Append("\n");
                        escaped = false;
                        return EvaluatorState.Running;
                }
            }

            if (stringStarter.StartsWith(info.Value))
            {
                if (multiCharacterStarterRecieved && info.Value == "]")
                {
                    completed = true;
                    Value.Value = source.ToString();
                    return EvaluatorState.Accepted;
                }
                else if (info.Value == "]")
                {
                    multiCharacterStarterRecieved = true;
                }
                else
                {
                    completed = true;
                    Value.Value = source.ToString();
                    return EvaluatorState.Accepted;
                }
            }
            else if (multiCharacterStarterRecieved)
            {
                // ']' character appeared without ending multiline string
                source.Append("]");
            }

            source.Append(info.Value);
            return EvaluatorState.Running;
        }
    }
}

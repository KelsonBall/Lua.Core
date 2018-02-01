using Lua.Parser.Statements;
using System.Collections.Generic;

namespace Lua.Parser
{
    public class BlockEvaluator : AstEvaluator
    {
        public override EvaluatorState Evaluate(Token info)
        {
            base.Evaluate(info);
            throw new NotImplementedException();
        }

        public override Evaluator<Token, AstNode> Copy()
        {
            throw new NotImplementedException();
        }
    }
}

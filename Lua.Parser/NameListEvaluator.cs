using Lua.AbstractSyntaxTree;
using Lua.Common;
using Lua.Tokenizer;
using System;

namespace Lua.Parser
{
    public class NameListEvaluator : AstEvaluator
    {
        public NameListEvaluator()
        {
            Value = SetMetadata(new NameList());
        }

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

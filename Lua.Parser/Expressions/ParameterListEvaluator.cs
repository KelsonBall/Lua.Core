using Lua.AbstractSyntaxTree;
using Lua.AbstractSyntaxTree.Expressions;
using Lua.Common;
using Lua.Tokenizer;
using System;

namespace Lua.Parser.Expressions
{
    public class ParameterListEvaluator : AstEvaluator
    {
        public ParameterListEvaluator()
        {
            Value = SetMetadata(new ParameterList());
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

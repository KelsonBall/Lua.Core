using Lua.AbstractSyntaxTree;
using Lua.AbstractSyntaxTree.Statements;
using Lua.Common;
using Lua.Tokenizer;
using System;

namespace Lua.Parser.Statements
{
    public class ForEachLoopEvaluator : StatementEvaluator
    {
        public ForEachLoopEvaluator()
        {
            Value = SetMetadata(new ForEachLoop());
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

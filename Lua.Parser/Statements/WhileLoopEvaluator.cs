using Lua.AbstractSyntaxTree;
using Lua.Common;
using Lua.Tokenizer;
using System;
using Lua.AbstractSyntaxTree.Statements;

namespace Lua.Parser.Statements
{
    public class WhileLoopEvaluator : StatementEvaluator
    {
        public WhileLoopEvaluator()
        {
            Value = SetMetadata(new WhileLoop());
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

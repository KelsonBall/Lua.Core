using Lua.AbstractSyntaxTree;
using Lua.AbstractSyntaxTree.Expressions;
using Lua.Common;
using Lua.Tokenizer;
using System;

namespace Lua.Parser.Expressions
{
    public class BinaryExpressionEvaluator : ExpressionEvaluator
    {
        public BinaryExpressionEvaluator()
        {
            Value = SetMetadata(new BinaryExpression());
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

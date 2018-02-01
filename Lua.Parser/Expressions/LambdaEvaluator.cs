using Lua.AbstractSyntaxTree;
using Lua.AbstractSyntaxTree.Expressions;
using Lua.Common;
using Lua.Tokenizer;
using System;

namespace Lua.Parser.Expressions
{
    /// <summary>
    /// lambda ::= ‘(’ [parlist] ‘)’ => expression
    /// </summary>
    public class LambdaEvaluator : ExpressionEvaluator
    {
        public LambdaEvaluator()
        {
            Value = SetMetadata(new Lambda());
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

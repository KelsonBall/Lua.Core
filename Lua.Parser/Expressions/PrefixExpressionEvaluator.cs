using Lua.AbstractSyntaxTree;
using Lua.AbstractSyntaxTree.Expressions;
using Lua.Common;
using Lua.Tokenizer;
using System;

namespace Lua.Parser.Expressions
{
    /// <summary>
    /// prefixexp ::= var | functioncall | ( exp )
    /// </summary>
    public abstract class PrefixExpressionEvaluator : ExpressionEvaluator
    {

    }

    public class PrefixVariableEvaluator : PrefixExpressionEvaluator
    {
        public PrefixVariableEvaluator()
        {
            Value = SetMetadata(new PrefixVariable());
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

    /// <summary>
    /// functioncall ::=  prefixexp args | prefixexp ‘:’ Name args
    /// </summary>
    public class PrefixFunctionEvaluator : PrefixExpressionEvaluator
    {
        public PrefixFunctionEvaluator()
        {
            Value = SetMetadata(new PrefixFunction());
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

    public class PrefixParenExpressionEvaluator : PrefixExpressionEvaluator
    {
        public PrefixParenExpressionEvaluator()
        {
            Value = SetMetadata(new PrefixParenExpression());
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

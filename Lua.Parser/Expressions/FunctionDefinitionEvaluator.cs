using Lua.AbstractSyntaxTree;
using Lua.AbstractSyntaxTree.Expressions;
using Lua.Common;
using Lua.Tokenizer;
using System;

namespace Lua.Parser.Expressions
{
    /// <summary>
    /// functiondef ::= function ‘(’ [parlist] ‘)’ block end
    /// </summary>
    public class FunctionDefinitionEvaluator : ExpressionEvaluator
    {
        public FunctionDefinitionEvaluator()
        {
            Value = SetMetadata(new FunctionDefinition());
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

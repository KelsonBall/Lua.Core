using System.Collections.Generic;
using Lua.Parser.Expressions;
using Lua.Parser.Terminals;
using Lua.AbstractSyntaxTree;
using Lua.AbstractSyntaxTree.Variables;
using Lua.Common;
using Lua.Tokenizer;
using System;

namespace Lua.Parser
{
    /// <summary>
    /// args ::=  ‘(’ [explist] ‘)’ | tableconstructor | LiteralString
    /// </summary>
    public abstract class ArgumentsEvaluator : AstEvaluator
    {
    }

    public class ExpressionArgsEvaluator : ArgumentsEvaluator
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

    public class TableArgEvaluator : ArgumentsEvaluator
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

    public class StringArgEvaluator : ArgumentsEvaluator
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

﻿using Lua.AbstractSyntaxTree;
using Lua.AbstractSyntaxTree.Statements;
using Lua.Common;
using Lua.Tokenizer;
using System;

namespace Lua.Parser.Statements
{
    public class FunctionStatementEvaluator : StatementEvaluator
    {
        public FunctionStatementEvaluator()
        {
            Value = SetMetadata(new FunctionStatement());
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

﻿using Lua.AbstractSyntaxTree;
using Lua.AbstractSyntaxTree.Terminals;
using Lua.Common;
using Lua.Tokenizer;
using System;

namespace Lua.Parser.Terminals
{
    public class NumberEvaluator : AstEvaluator
    {
        public NumberEvaluator()
        {
            Value = SetMetadata(new Number());
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

using Lua.AbstractSyntaxTree;
using Lua.Common;
using Lua.Tokenizer;
using System;
using Boolean = Lua.AbstractSyntaxTree.Terminals.Boolean;

namespace Lua.Parser.Terminals
{
    public class BooleanEvaluator : AstEvaluator
    {
        public BooleanEvaluator()
        {
            Value = SetMetadata(new Boolean());
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

using Lua.AbstractSyntaxTree;
using Lua.Common;
using Lua.Tokenizer;
using System;
using String = Lua.AbstractSyntaxTree.Terminals.String;

namespace Lua.Parser.Terminals
{
    public class StringEvaluator : AstEvaluator
    {
        public StringEvaluator()
        {
            Value = SetMetadata(new String());
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

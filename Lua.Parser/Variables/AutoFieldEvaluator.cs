using Lua.AbstractSyntaxTree;
using Lua.AbstractSyntaxTree.Variables;
using Lua.Common;
using Lua.Tokenizer;
using System;

namespace Lua.Parser.Variables
{
    public class AutoFieldEvaluator : Field
    {
        public AutoFieldEvaluator()
        {
            Value = SetMetadata(new AutoField());
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

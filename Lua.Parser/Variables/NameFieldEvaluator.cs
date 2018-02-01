using Lua.AbstractSyntaxTree;
using Lua.AbstractSyntaxTree.Variables;
using Lua.Common;
using Lua.Tokenizer;
using System;

namespace Lua.Parser.Variables
{
    public class NameFieldEvaluator : Field
    {
        public NameFieldEvaluator()
        {
            Value = SetMetadata(new NameField());
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

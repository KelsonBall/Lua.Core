using Lua.AbstractSyntaxTree;
using Lua.AbstractSyntaxTree.Statements;
using Lua.Common;
using Lua.Tokenizer;
using System;

namespace Lua.Parser.Statements
{
    public class LabelEvaluator : StatementEvaluator
    {
        public LabelEvaluator()
        {
            Value = SetMetadata(new Label());
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

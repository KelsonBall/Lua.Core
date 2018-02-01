using Lua.AbstractSyntaxTree;
using Lua.AbstractSyntaxTree.Variables;
using Lua.Common;
using Lua.Tokenizer;
using System;

namespace Lua.Parser.Variables
{
    /// <summary>
    /// fieldlist ::= field {fieldsep field} [fieldsep]
    /// </summary>
    public class FieldListEvaluator : AstEvaluator
    {
        public FieldListEvaluator()
        {
            Value = SetMetadata(new FieldList());
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

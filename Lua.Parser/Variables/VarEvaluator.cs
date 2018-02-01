using System;
using Lua.AbstractSyntaxTree;
using Lua.Common;
using Lua.Tokenizer;

namespace Lua.Parser.Variables
{
    /// <summary>
    /// A variable reference
    /// var ::= Name | prefixexp ‘[’ exp ‘]’ | prefixexp ‘.’ Name
    /// </summary>
    public abstract class VarEvaluator : AstEvaluator
    {
    }

    public class VarNameEvaluator : VarEvaluator
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

    /// <summary>
    /// VarTableKey ::= prefixexp ‘[’ exp ‘]’
    /// </summary>
    public class VarTableKeyEvaluator : VarEvaluator
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

    /// <summary>
    /// VarObjectKey ::= prefixexp ‘.’ Name
    /// </summary>
    public class VarObjectKeyEvaluator : VarEvaluator
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

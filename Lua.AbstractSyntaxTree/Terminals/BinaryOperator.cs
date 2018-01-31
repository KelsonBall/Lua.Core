using System.Collections.Generic;

namespace Lua.AbstractSyntaxTree.Terminals
{
    public enum BinOp
    {
        Add,
        Sub,
        Multiply,
        Divide,
        Modulus,
        Concat,
        LessThan,
        LessThanEqual,
        GreaterThan,
        GreaterThanEqual,
        Equal,
        NotEqual,
        And,
        Or
    }

    public class BinaryOperator : AstNode
    {
        public BinOp Operator;

        protected override IEnumerable<AstNode> Nodes()
        {
            yield break;
        }
    }
}

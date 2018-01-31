using System.Collections.Generic;

namespace Lua.AbstractSyntaxTree.Terminals
{
    public enum UnOp
    {
        Minus,
        Not,
        Length,
    }

    public class UnaryOperator : AstNode
    {
        public UnOp Operator;

        protected override IEnumerable<AstNode> Nodes()
        {
            yield break;
        }
    }
}

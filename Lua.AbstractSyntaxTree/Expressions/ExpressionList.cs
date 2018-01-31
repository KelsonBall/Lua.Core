using System.Collections.Generic;

namespace Lua.AbstractSyntaxTree.Expressions
{
    public class ExpressionList : AstNode
    {
        public readonly List<Expression> Expressions = new List<Expression>();

        protected override IEnumerable<AstNode> Nodes() => Expressions;
    }
}

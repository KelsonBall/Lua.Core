using Lua.AbstractSyntaxTree.Expressions;
using System.Collections.Generic;

namespace Lua.AbstractSyntaxTree.Statements
{
    public class Return : AstNode
    {
        public Expression Expression;

        protected override IEnumerable<AstNode> Nodes()
        {
            if (Expression != null)
                yield return Expression;
        }
    }
}

using System.Collections.Generic;
using Lua.AbstractSyntaxTree.Expressions;
using Lua.AbstractSyntaxTree.Variables;

namespace Lua.AbstractSyntaxTree.Statements
{
    public class LocalAssignment : Statement
    {
        public VarList Variables;
        public ExpressionList Expressions;

        protected override IEnumerable<AstNode> Nodes()
        {
            yield return Variables;
            yield return Expressions;
        }
    }
}

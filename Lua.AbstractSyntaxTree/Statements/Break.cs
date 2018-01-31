using System.Collections.Generic;

namespace Lua.AbstractSyntaxTree.Statements
{
    public class Break : Statement
    {
        protected override IEnumerable<AstNode> Nodes()
        {
            yield break;
        }
    }
}

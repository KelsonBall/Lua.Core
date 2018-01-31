using System.Collections.Generic;

namespace Lua.AbstractSyntaxTree.Terminals
{
    public class Nil : AstNode
    {
        protected override IEnumerable<AstNode> Nodes()
        {
            yield break;
        }
    }
}

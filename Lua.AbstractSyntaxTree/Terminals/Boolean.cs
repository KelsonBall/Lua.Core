using System.Collections.Generic;

namespace Lua.AbstractSyntaxTree.Terminals
{
    public class Boolean : AstNode
    {
        public bool Value;

        protected override IEnumerable<AstNode> Nodes()
        {
            yield break;
        }
    }
}

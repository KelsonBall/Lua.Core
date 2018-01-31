using System.Collections.Generic;

namespace Lua.AbstractSyntaxTree.Terminals
{
    public class Number : AstNode
    {
        public object Value;

        protected override IEnumerable<AstNode> Nodes()
        {
            yield break;
        }
    }
}

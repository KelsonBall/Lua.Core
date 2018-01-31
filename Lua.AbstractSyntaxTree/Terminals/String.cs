using System.Collections.Generic;

namespace Lua.AbstractSyntaxTree.Terminals
{
    public class String : AstNode
    {
        public string Value;

        protected override IEnumerable<AstNode> Nodes()
        {
            yield break;
        }
    }
}

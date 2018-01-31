using System.Collections.Generic;

namespace Lua.AbstractSyntaxTree.Terminals
{
    public class Name : AstNode
    {
        public string Value;

        protected override IEnumerable<AstNode> Nodes()
        {
            yield break;
        }
    }
}

using System.Collections.Generic;

namespace Lua.AbstractSyntaxTree.Statements
{
    public class DoBlock : Statement
    {
        public Block Block;

        protected override IEnumerable<AstNode> Nodes()
        {
            yield return Block;
        }
    }
}

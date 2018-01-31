using Lua.AbstractSyntaxTree.Statements;
using System.Collections.Generic;

namespace Lua.AbstractSyntaxTree
{
    public class Chunk : AstNode
    {
        public readonly List<Import> Imports = new List<Import>();
        public Block Body;

        protected override IEnumerable<AstNode> Nodes()
        {
            foreach (var import in Imports)
                yield return import;
            yield return Body;
        }
    }
}

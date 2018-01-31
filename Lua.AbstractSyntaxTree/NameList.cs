using Lua.AbstractSyntaxTree.Terminals;
using System.Collections.Generic;

namespace Lua.AbstractSyntaxTree
{
    public class NameList : AstNode
    {
        public readonly List<Name> Names = new List<Name>();

        protected override IEnumerable<AstNode> Nodes() => Names;
    }
}

using System.Collections.Generic;
using Lua.AbstractSyntaxTree.Terminals;

namespace Lua.AbstractSyntaxTree.Statements
{
    public class Goto : Statement
    {
        public Name Name;

        protected override IEnumerable<AstNode> Nodes()
        {
            yield return Name;
        }
    }
}

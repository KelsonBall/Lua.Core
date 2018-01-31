using System.Collections.Generic;
using Lua.AbstractSyntaxTree.Terminals;

namespace Lua.AbstractSyntaxTree.Statements
{
    /// <summary>
    /// label ::= ‘::’ Name ‘::’
    /// </summary>
    public class Label : Statement
    {
        public Name Name;

        protected override IEnumerable<AstNode> Nodes()
        {
            yield return Name;
        }
    }
}

using Lua.AbstractSyntaxTree.Terminals;
using System.Collections.Generic;

namespace Lua.AbstractSyntaxTree.Variables
{
    public class NameField : Field
    {
        public Name Key;

        protected override IEnumerable<AstNode> Nodes()
        {
            yield return Key;
            yield return Value;
        }
    }

}

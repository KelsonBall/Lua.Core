using Lua.AbstractSyntaxTree.Expressions;
using System.Collections.Generic;

namespace Lua.AbstractSyntaxTree.Variables
{
    public class KeyField : Field
    {
        public Expression Key;

        protected override IEnumerable<AstNode> Nodes()
        {
            yield return Key;
            yield return Value;
        }
    }

}

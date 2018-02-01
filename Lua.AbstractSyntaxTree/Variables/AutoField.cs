using System.Collections.Generic;

namespace Lua.AbstractSyntaxTree.Variables
{
    public class AutoField : Field
    {
        protected override IEnumerable<AstNode> Nodes()
        {
            yield return Value;
        }
    }

}

using System.Collections.Generic;

namespace Lua.AbstractSyntaxTree.Expressions
{
    public class ParameterList : AstNode
    {
        public NameList Parameters;
        public bool VarArgs;

        protected override IEnumerable<AstNode> Nodes()
        {
            yield return Parameters;
        }
    }
}

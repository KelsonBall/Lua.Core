using System.Collections.Generic;

namespace Lua.AbstractSyntaxTree.Variables
{
    public class VarList : AstNode
    {
        public readonly List<Var> Variables = new List<Var>();

        protected override IEnumerable<AstNode> Nodes() => Variables;
    }
}

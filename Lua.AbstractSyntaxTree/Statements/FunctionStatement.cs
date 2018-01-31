using System.Collections.Generic;
using Lua.AbstractSyntaxTree.Expressions;
using Lua.AbstractSyntaxTree.Terminals;

namespace Lua.AbstractSyntaxTree.Statements
{
    public class FunctionStatement : Statement
    {
        public Name Name;
        public ParameterList Parameters;
        public Block Body;

        protected override IEnumerable<AstNode> Nodes()
        {
            yield return Name;
            yield return Parameters;
            yield return Body;
        }
    }
}

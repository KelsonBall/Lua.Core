using System.Collections.Generic;

namespace Lua.AbstractSyntaxTree.Expressions
{
    /// <summary>
    /// functiondef ::= function ‘(’ [parlist] ‘)’ block end
    /// </summary>
    public class FunctionDefinition : Expression
    {
        public ParameterList Parameters;
        public Block Block;

        protected override IEnumerable<AstNode> Nodes()
        {
            yield return Parameters;
            yield return Block;
        }
    }
}

using System.Collections.Generic;

namespace Lua.AbstractSyntaxTree.Expressions
{
    /// <summary>
    /// lambda ::= ‘(’ [parlist] ‘)’ => expression
    /// </summary>
    public class Lambda : Expression
    {
        public ParameterList Parameters;
        public Expression Expression;

        protected override IEnumerable<AstNode> Nodes()
        {
            yield return Parameters;
            yield return Expression;
        }
    }
}

using System.Collections.Generic;
using Lua.AbstractSyntaxTree.Terminals;

namespace Lua.AbstractSyntaxTree.Expressions
{
    public class UnaryExpression : Expression
    {
        public UnaryOperator Operator;
        public Expression Expression;

        protected override IEnumerable<AstNode> Nodes()
        {
            yield return Operator;
            yield return Expression;
        }
    }
}

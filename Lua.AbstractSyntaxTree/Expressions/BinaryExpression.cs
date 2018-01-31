using System.Collections.Generic;
using Lua.AbstractSyntaxTree.Terminals;

namespace Lua.AbstractSyntaxTree.Expressions
{
    public class BinaryExpression : Expression
    {
        public Expression First;
        public BinaryOperator Operator;
        public Expression Second;

        protected override IEnumerable<AstNode> Nodes()
        {
            yield return First;
            yield return Operator;
            yield return Second;
        }
    }
}

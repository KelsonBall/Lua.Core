using System.Collections.Generic;
using Lua.AbstractSyntaxTree.Expressions;

namespace Lua.AbstractSyntaxTree.Statements
{
    public class WhileLoop : Statement
    {
        public Expression Condition;
        public Block Block;

        protected override IEnumerable<AstNode> Nodes()
        {
            yield return Condition;
            yield return Block;
        }
    }
}

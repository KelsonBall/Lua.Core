using System.Collections.Generic;
using Lua.AbstractSyntaxTree.Expressions;

namespace Lua.AbstractSyntaxTree.Statements
{
    public class RepeatLoop : Statement
    {
        public Block Block;
        public Expression Condition;

        protected override IEnumerable<AstNode> Nodes()
        {
            yield return Block;
            yield return Condition;
        }
    }
}

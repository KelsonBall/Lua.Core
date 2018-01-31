using System.Collections.Generic;
using Lua.AbstractSyntaxTree.Expressions;
using Lua.AbstractSyntaxTree.Terminals;

namespace Lua.AbstractSyntaxTree.Statements
{
    public class ForLoop : Statement
    {
        public Name Iterator;
        public Expression From;
        public Expression To;
        public Expression Step;
        public Block Block;

        protected override IEnumerable<AstNode> Nodes()
        {
            yield return Iterator;
            yield return From;
            yield return To;
            if (Step != null)
                yield return Step;
            yield return Block;
        }
    }
}

using System.Collections.Generic;
using Lua.AbstractSyntaxTree.Expressions;

namespace Lua.AbstractSyntaxTree.Statements
{
    public class ForEachLoop : Statement
    {
        public NameList Names;
        public ExpressionList Expressions;
        public Block Block;

        protected override IEnumerable<AstNode> Nodes()
        {
            yield return Names;
            yield return Expressions;
            yield return Block;
        }
    }
}

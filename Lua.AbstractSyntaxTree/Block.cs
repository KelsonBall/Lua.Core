using Lua.AbstractSyntaxTree.Statements;
using System.Collections.Generic;

namespace Lua.AbstractSyntaxTree
{
    public class Block : AstNode
    {
        public readonly List<Statement> Statements = new List<Statement>();

        public Return Return;

        protected override IEnumerable<AstNode> Nodes()
        {
            foreach (var statement in Statements)
                yield return statement;
            if (Return != null)
                yield return Return;
        }
    }
}

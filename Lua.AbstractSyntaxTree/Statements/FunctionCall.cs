using System.Collections.Generic;
using Lua.AbstractSyntaxTree.Expressions;
using Lua.AbstractSyntaxTree.Terminals;

namespace Lua.AbstractSyntaxTree.Statements
{
    public class FunctionCall : Statement
    {
        public PrefixExpression Prefix;
        public Arguments Args;
        public Name PipeIdentifier; // null if not piped

        protected override IEnumerable<AstNode> Nodes()
        {
            yield return Prefix;
            yield return Args;
            if (PipeIdentifier != null)
                yield return PipeIdentifier;
        }
    }
}

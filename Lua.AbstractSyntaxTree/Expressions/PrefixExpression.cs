using System.Collections.Generic;
using Lua.AbstractSyntaxTree.Terminals;
using Lua.AbstractSyntaxTree.Variables;

namespace Lua.AbstractSyntaxTree.Expressions
{
    /// <summary>
    /// prefixexp ::= var | functioncall | ( exp )
    /// </summary>
    public abstract class PrefixExpression : Expression
    {

    }

    public class PrefixVariable : PrefixExpression
    {
        public Var Prefix;

        protected override IEnumerable<AstNode> Nodes()
        {
            yield return Prefix;
        }
    }

    /// <summary>
    /// functioncall ::=  prefixexp args | prefixexp ‘:’ Name args
    /// </summary>
    public class PrefixFunction : PrefixExpression
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

    public class PrefixParenExpression : PrefixExpression
    {
        public Expression Expression;

        protected override IEnumerable<AstNode> Nodes()
        {
            yield return Expression;
        }
    }
}

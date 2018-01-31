using System.Collections.Generic;
using Lua.AbstractSyntaxTree.Expressions;
using Lua.AbstractSyntaxTree.Terminals;

namespace Lua.AbstractSyntaxTree.Variables
{
    /// <summary>
    /// A variable reference
    /// var ::= Name | prefixexp ‘[’ exp ‘]’ | prefixexp ‘.’ Name
    /// </summary>
    public abstract class Var : AstNode
    {
    }

    public class VarName : Var
    {
        public Name Name;

        protected override IEnumerable<AstNode> Nodes()
        {
            yield return Name;
        }
    }

    /// <summary>
    /// VarTableKey ::= prefixexp ‘[’ exp ‘]’
    /// </summary>
    public class VarTableKey : Var
    {
        public PrefixExpression Prefix;
        public Expression Key;

        protected override IEnumerable<AstNode> Nodes()
        {
            yield return Prefix;
            yield return Key;
        }
    }

    /// <summary>
    /// VarObjectKey ::= prefixexp ‘.’ Name
    /// </summary>
    public class VarObjectKey : Var
    {
        public PrefixExpression Expression;
        public Name Key;

        protected override IEnumerable<AstNode> Nodes()
        {
            yield return Expression;
            yield return Key;
        }
    }
}

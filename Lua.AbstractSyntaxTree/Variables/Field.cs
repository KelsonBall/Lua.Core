using Lua.AbstractSyntaxTree.Expressions;
using Lua.AbstractSyntaxTree.Terminals;
using System.Collections.Generic;

namespace Lua.AbstractSyntaxTree.Variables
{
    /// <summary>
    /// field ::= ‘[’ exp ‘]’ ‘=’ exp | Name ‘=’ exp | exp
    /// </summary>
    public abstract class Field : AstNode
    {
        public Expression Value;
    }

    public class KeyField : Field
    {
        public Expression Key;

        protected override IEnumerable<AstNode> Nodes()
        {
            yield return Key;
            yield return Value;
        }
    }

    public class NameField : Field
    {
        public Name Key;

        protected override IEnumerable<AstNode> Nodes()
        {
            yield return Key;
            yield return Value;
        }
    }

    public class AutoField : Field
    {
        protected override IEnumerable<AstNode> Nodes()
        {
            yield return Value;
        }
    }

}

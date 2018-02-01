using Lua.AbstractSyntaxTree.Expressions;

namespace Lua.AbstractSyntaxTree.Variables
{
    /// <summary>
    /// field ::= ‘[’ exp ‘]’ ‘=’ exp | Name ‘=’ exp | exp
    /// </summary>
    public abstract class Field : AstNode
    {
        public Expression Value;
    }
}

using System.Collections.Generic;
using Lua.AbstractSyntaxTree.Expressions;
using Lua.AbstractSyntaxTree.Terminals;

namespace Lua.AbstractSyntaxTree
{
    /// <summary>
    /// args ::=  ‘(’ [explist] ‘)’ | tableconstructor | LiteralString
    /// </summary>
    public abstract class Arguments : AstNode
    {
    }

    public class ExpressionArgs : Arguments
    {
        public ExpressionList Expressions;

        protected override IEnumerable<AstNode> Nodes() => Expressions;
    }

    public class TableArg : Arguments
    {
        public TableConstructor Table;

        protected override IEnumerable<AstNode> Nodes()
        {
            yield return Table;
        }
    }

    public class StringArg : Arguments
    {
        public String Argument;

        protected override IEnumerable<AstNode> Nodes()
        {
            yield return Argument;
        }
    }
}

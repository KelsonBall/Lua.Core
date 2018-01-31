using System.Collections.Generic;
using Lua.AbstractSyntaxTree.Variables;

namespace Lua.AbstractSyntaxTree.Expressions
{
    /// <summary>
    /// tableconstructor ::= ‘{’ [fieldlist] ‘}’
    /// </summary>
    public class TableConstructor : Expression
    {
        public FieldList Fields;

        protected override IEnumerable<AstNode> Nodes()
        {
            yield return Fields;
        }
    }
}

using System.Collections.Generic;

namespace Lua.AbstractSyntaxTree.Variables
{
    /// <summary>
    /// fieldlist ::= field {fieldsep field} [fieldsep]
    /// </summary>
    public class FieldList : AstNode
    {
        public readonly List<Field> Fields = new List<Field>();

        protected override IEnumerable<AstNode> Nodes() => Fields;
    }
}

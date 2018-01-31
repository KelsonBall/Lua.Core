using Lua.AbstractSyntaxTree.Terminals;
using System.Collections.Generic;

namespace Lua.AbstractSyntaxTree.Statements
{
    /// <summary>
    /// Represents importing a dotnet dll
    /// Import ::=  using Name {.Name}
    ///             using Name {.Name} from <string>
    /// </summary>
    public class Import : AstNode
    {
        public string Path; // null for netstandard.dll
        public List<Name> Names;

        protected override IEnumerable<AstNode> Nodes() => Names;
    }
}

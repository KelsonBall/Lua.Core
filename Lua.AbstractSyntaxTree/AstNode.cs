using System.Collections;
using System.Collections.Generic;

namespace Lua.AbstractSyntaxTree
{
    public abstract class AstNode : IEnumerable<AstNode>
    {
        public readonly Dictionary<string, object> Metadata = new Dictionary<string, object>();

        protected abstract IEnumerable<AstNode> Nodes();

        public IEnumerator<AstNode> GetEnumerator() => Nodes().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}

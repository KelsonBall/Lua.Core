using System.Collections.Generic;
using Lua.AbstractSyntaxTree.Expressions;

namespace Lua.AbstractSyntaxTree.Statements
{
    public class If : Statement
    {
        public Expression Condition;
        public Block Block;
        public readonly List<If> ElseIfs = new List<If>();
        public Block Else;

        protected override IEnumerable<AstNode> Nodes()
        {
            yield return Condition;
            yield return Block;
            foreach (var @if in ElseIfs)
            {
                yield return @if.Condition;
                yield return @if.Block;
            }
            if (Else != null)
                yield return Else;
        }
    }
}

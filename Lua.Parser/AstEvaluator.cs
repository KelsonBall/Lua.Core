using Lua.AbstractSyntaxTree;
using Lua.Common;
using Lua.Tokenizer;
using System.Collections.Generic;

namespace Lua.Parser
{
    public abstract class AstEvaluator : Evaluator<Token, AstNode>
    {
        public override EvaluatorState Evaluate(Token info)
        {
            ((List<Token>)Value.Metadata["Tokens"]).Add(info);
            return EvaluatorState.Running;
        }

        protected AstNode SetMetadata(AstNode node)
        {
            node.Metadata["Tokens"] = new List<Token>();
            return node;
        }
    }
}

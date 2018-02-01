namespace Lua.Parser.Expressions
{
    /// <summary>
    /// exp ::= nil | <bool> | <number> | <string> | ‘...’ | functiondef | lambda | prefixexp | tableconstructor | exp binop exp | unop exp
    /// </summary>
    public abstract class ExpressionEvaluator : AstEvaluator
    {
    }
}

using System.Collections.Generic;

namespace Lua.Tokenizer
{
    public static class StringExtensions
    {
        public static IEnumerable<Token> ToTokens(this string source) => Token.Parse(CharacterInfo.Parse(source));
    }
}

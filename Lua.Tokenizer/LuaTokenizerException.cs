using System;

namespace Lua.Tokenizer
{
    public class LuaTokenizerException : Exception
    {
        public LuaTokenizerException() : base() { }
        public LuaTokenizerException(string message) : base(message) { }
    }

}

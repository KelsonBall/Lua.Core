using Lua.Tokenizer;
using System;
using System.Linq;

namespace Lua.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var source = Console.ReadLine();
                var token = Token.Parse(CharacterInfo.Parse(source)).ToList();
                Console.WriteLine(string.Join("", token.Select(t => t.ToString())));
            }
        }
    }
}

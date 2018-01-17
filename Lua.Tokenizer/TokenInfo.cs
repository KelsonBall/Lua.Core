using System.Collections.Generic;
using System.Linq;

namespace Lua.Tokenizer
{
    public partial class Token
    {
        public static readonly string[] StructuralPunctuation = new string[]
        {
            "...", "(", ")", ",", "[", "]", "\"",
            "=", ";", ":", ".",  "::", "{", "}",
            "\\",
        };

        public static readonly string[] UnOp = new string[]
        {
            "-", "#", "not",
        };

        public static readonly string[] BinOp = new string[]
        {
            "+", "-", "*", "/", "^", "%", "&", "~", "|", ">>", "<<", "..",
            "<", "<=", ">", ">=", "==", "~=", "and", "or",
        };

        public static readonly string[] Operators =
            BinOp
                .Concat(UnOp)
                .Distinct()
                .ToArray();

        public static readonly string[] ReservedWords = new string[]
        {
            "break",     "do",        "else",      "elseif",    "end",
            "for",       "function",  "goto",      "if",        "in",
            "local",     "not",     "repeat",    "return",    "then",
            "until",     "while",   "nil",  "true",     "false",    "and",
            "or"
        };

        public static readonly string[] Keywords = new string[]
        {
            "break",     "do",        "else",      "elseif",    "end",
            "for",       "function",  "goto",      "if",        "in",
            "local",    "repeat",    "return",    "then",   "until",     "while",
        };

        public static readonly string[] Values = new string[]
        {
            "nil", "true", "false"
        };

        public static readonly string[] Whitespace = new string[] { " ", "\t", "\r", "\n", "\f", "\v" };
        public static readonly char[] WhitespaceChars = Whitespace.Select(w => w.Single()).ToArray();

        public static readonly string[] Literal =
            StructuralPunctuation
                .Concat(UnOp)
                .Concat(BinOp)
                .Concat(Keywords)
                .Concat(Values)
                .ToArray();

        public static string Alphabet = "abcdefghijklmnopqrstuvwxyz";

        public static IEnumerable<string> Digits(int numberbase = 10)
        {
            return "0123456789ABCDEFGH".Take(numberbase).Select(c => c.ToString());
        }

        public static string[] NonAlphabetLiterals = Literal.Where(l => !l.Any(c => Alphabet.Contains(c))).ToArray();

        public static readonly string[] IdentifierCharacters =
            (Alphabet + "_")
                         .SelectMany(c => new[] { c.ToString(), c.ToString().ToUpperInvariant() })
                         .ToArray();
    }
}

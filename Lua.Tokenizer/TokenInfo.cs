using System.Linq;

namespace Lua.Tokenizer
{
    public static class TokenData
    {
        public static bool Is(this string c, string[] items) => items.Any(s => s.Contains(c));

        public static bool IsCharOf(this string c, int offset, string[] items) => items.Any(s =>
        {
            if (s.Length <= offset)
                return false;
            return s[offset].ToString() == c;
        });

        public static bool IsLastCharOf(this string c, int offset, string[] items) => items.Any(s =>
        {
            return c == s.Last().ToString() && offset == s.Length - 1;
        });

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

        public static readonly string[] Keyword = new string[]
        {
            "break",     "do",        "else",      "elseif",    "end",
            "for",       "function",  "goto",      "if",        "in",
            "local",     "repeat",    "return",    "then",      "until",     "while",
        };

        public static readonly string[] Value = new string[]
        {
            "nil", "true", "false"
        };

        public static readonly string[] Whitespace = new string[] { " ", "\t", "\r", "\n", "\f", "\v" };
        public static readonly char[] WhitespaceChars = Whitespace.Select(w => w.Single()).ToArray();

        public static readonly string[] Literal =
            StructuralPunctuation
                .Concat(UnOp)
                .Concat(BinOp)
                .Concat(Keyword)
                .Concat(Value)
                .ToArray();

        public static string Alphabet = "abcdefghijklmnopqrstuvwxyz";

        public static string[] NonAlphabetLiterals = Literal.Where(l => !l.Any(c => Alphabet.Contains(c))).ToArray();

        public static readonly string[] IdentifierCharacters =
            (Alphabet + "_")
                         .SelectMany(c => new[] { c.ToString(), c.ToString().ToUpperInvariant() })
                         .ToArray();
    }
}

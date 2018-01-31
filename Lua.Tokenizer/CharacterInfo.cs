using System;
using System.Collections.Generic;

namespace Lua.Tokenizer
{
    /// <summary>
    /// Preserves info about a characters location in the source code for later use by debugging and analtyic tools
    /// </summary>
    public class CharacterInfo
    {
        public string Value { get; set; }
        public int Offset { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }

        public override int GetHashCode() => Value.GetHashCode();

        public override bool Equals(object obj) => Value.Equals(obj);

        public static IEnumerable<CharacterInfo> Parse(IEnumerable<char> characters)
        {
            int row = 0;
            int column = 0;
            int offset = 0;
            foreach (var v in characters)
            {
                offset++;
                yield return new CharacterInfo
                {
                    Value = v.ToString(),
                    Offset = offset,
                    Row = row,
                    Column = column
                };
                if (v == '\r')
                {
                    row++;
                    column = 0;
                }
                else
                {
                    column++;
                }
            }
            yield return new CharacterInfo
            {
                Value = " ",
                Offset = 0,
                Row = 0,
                Column = 0
            };
        }

        public override string ToString() => Value;
    }
}

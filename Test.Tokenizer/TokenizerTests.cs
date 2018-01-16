using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lua.Tokenizer;
using System.Linq;

namespace Test.Tokenizer
{
    [TestClass]
    public class TokenizerTests
    {
        [TestMethod]
        public void KeywordTokenTest()
        {
            string source = "function";

            var token = Token.Parse(CharacterInfo.Parse(source)).Single();
            Assert.AreEqual(token.Source, "function");
            Assert.AreEqual(token.Type, TokenType.Keyword);
        }

        [TestMethod]
        public void IdentifierTest()
        {
            string source = "x";
            var token = Token.Parse(CharacterInfo.Parse(source)).Single();
            Assert.AreEqual(token.Source, "x");
            Assert.AreEqual(token.Type, TokenType.Identifier);
        }

        [TestMethod]
        public void FunctionTest()
        {
            string source = "function add(x, y) return x + y end";
            var tokens = Token.Parse(CharacterInfo.Parse(source)).ToArray();
            Assert.AreEqual(tokens[0].Source, "function");
            Assert.AreEqual(tokens[0].Type, TokenType.Keyword);
            Assert.AreEqual(tokens[1].Source, " ");
            Assert.AreEqual(tokens[1].Type, TokenType.Whitespace);
            Assert.AreEqual(tokens[2].Source, "add");
            Assert.AreEqual(tokens[2].Type, TokenType.Identifier);
            Assert.AreEqual(tokens[3].Source, "(");
            Assert.AreEqual(tokens[3].Type, TokenType.Structural);
            Assert.AreEqual(tokens[4].Source, "x");
            Assert.AreEqual(tokens[4].Type, TokenType.Identifier);
            Assert.AreEqual(tokens[5].Source, ",");
            Assert.AreEqual(tokens[5].Type, TokenType.Structural);
            Assert.AreEqual(tokens[6].Source, " ");
            Assert.AreEqual(tokens[6].Type, TokenType.Whitespace);
            Assert.AreEqual(tokens[7].Source, "y");
            Assert.AreEqual(tokens[7].Type, TokenType.Identifier);
            Assert.AreEqual(tokens[8].Source, ")");
            Assert.AreEqual(tokens[8].Type, TokenType.Structural);
            Assert.AreEqual(tokens[9].Source, " ");
            Assert.AreEqual(tokens[9].Type, TokenType.Whitespace);
            Assert.AreEqual(tokens[10].Source, "return");
            Assert.AreEqual(tokens[10].Type, TokenType.Keyword);
            Assert.AreEqual(tokens[11].Source, " ");
            Assert.AreEqual(tokens[11].Type, TokenType.Whitespace);
            Assert.AreEqual(tokens[12].Source, "+");
            Assert.AreEqual(tokens[12].Type, TokenType.Operator);
            Assert.AreEqual(tokens[13].Source, " ");
            Assert.AreEqual(tokens[13].Type, TokenType.Whitespace);
            Assert.AreEqual(tokens[14].Source, "y");
            Assert.AreEqual(tokens[14].Type, TokenType.Identifier);
            Assert.AreEqual(tokens[15].Source, " ");
            Assert.AreEqual(tokens[15].Type, TokenType.Whitespace);
            Assert.AreEqual(tokens[16].Source, "end");
            Assert.AreEqual(tokens[16].Type, TokenType.Keyword);

        }
    }
}

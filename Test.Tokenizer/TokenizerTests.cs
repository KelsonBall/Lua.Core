using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lua.Tokenizer;
using System.Linq;
using System;

namespace Test.Tokenizer
{
    [TestClass]
    public class TokenizerTests
    {
        [TestMethod]
        public void KeywordTokenTest()
        {
            var token = "function".ToTokens().Single();
            Assert.AreEqual(token.Source, "function");
            Assert.AreEqual(token.Type, TokenType.Keyword);
        }

        [TestMethod]
        public void IdentifierTokenTest()
        {
            var token = "x".ToTokens().Single();
            Assert.AreEqual(token.Source, "x");
            Assert.AreEqual(token.Type, TokenType.Identifier);
        }

        [TestMethod]
        public void BooleanTokenTest()
        {
            Assert.IsTrue((bool)"true".ToTokens().Single().Value);
            Assert.IsFalse((bool)"false".ToTokens().Single().Value);
        }

        [TestMethod]
        public void NilTokenTest()
        {
            var token = "nil".ToTokens().Single();
            Assert.AreEqual(token.Source, "nil");
            Assert.AreEqual(token.Type, TokenType.Nil);
            Assert.IsNull(token.Value);
        }

        [TestMethod]
        public void OperatorTokenTest()
        {
            var token = ">=".ToTokens().Single();
            Assert.AreEqual(token.Source, ">=");
            Assert.AreEqual(token.Type, TokenType.Operator);
        }

        [TestMethod]
        public void StringTokenTest()
        {
            var token = "\"data\"".ToTokens().Last();
            Assert.AreEqual(token.Source, "\"data\"");
            Assert.AreEqual(token.Value, "data");
            Assert.AreEqual(token.Type, TokenType.String);
        }

        [TestMethod]
        public void StringMultilineTokenTest()
        {
            string source =
@"[[eggs
bacon]]";
            var tokens = source.ToTokens().ToArray();
            var token = tokens.Last();
            Assert.AreEqual(token.Source, source);
            Assert.AreEqual(token.Value, $"eggs{Environment.NewLine}bacon");
            Assert.AreEqual(token.Type, TokenType.String);
        }

        [TestMethod]
        public void NumberTokenTest()
        {
            var token = "12".ToTokens().Single();
            Assert.AreEqual(token.Source, "12");
            Assert.AreEqual(token.Value, 12);
            Assert.AreEqual(token.Type, TokenType.Number);

            token = "12.34".ToTokens().Single();
            Assert.AreEqual(token.Source, "12.34");
            Assert.AreEqual(token.Value, 12.34);
            Assert.AreEqual(token.Type, TokenType.Number);
        }

        [TestMethod]
        public void FullFunctionTokenTest()
        {
            string source = "function add(x, y) return x + y end";
            var tokens = source.ToTokens().ToArray();
            Assert.AreEqual(tokens[0].Source, "function");
            Assert.AreEqual(tokens[0].Type, TokenType.Keyword);
            Assert.AreEqual(tokens[1].Source, "add");
            Assert.AreEqual(tokens[1].Type, TokenType.Identifier);
            Assert.AreEqual(tokens[2].Source, "(");
            Assert.AreEqual(tokens[2].Type, TokenType.Structural);
            Assert.AreEqual(tokens[3].Source, "x");
            Assert.AreEqual(tokens[3].Type, TokenType.Identifier);
            Assert.AreEqual(tokens[4].Source, ",");
            Assert.AreEqual(tokens[4].Type, TokenType.Structural);
            Assert.AreEqual(tokens[5].Source, "y");
            Assert.AreEqual(tokens[5].Type, TokenType.Identifier);
            Assert.AreEqual(tokens[6].Source, ")");
            Assert.AreEqual(tokens[6].Type, TokenType.Structural);
            Assert.AreEqual(tokens[7].Source, "return");
            Assert.AreEqual(tokens[7].Type, TokenType.Keyword);
            Assert.AreEqual(tokens[8].Source, "x");
            Assert.AreEqual(tokens[8].Type, TokenType.Identifier);
            Assert.AreEqual(tokens[9].Source, "+");
            Assert.AreEqual(tokens[9].Type, TokenType.Operator);
            Assert.AreEqual(tokens[10].Source, "y");
            Assert.AreEqual(tokens[10].Type, TokenType.Identifier);
            Assert.AreEqual(tokens[11].Source, "end");
            Assert.AreEqual(tokens[11].Type, TokenType.Keyword);

        }
    }
}

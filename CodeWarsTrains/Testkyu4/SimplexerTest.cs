using System;
using System.Collections.Generic;
using kyu4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testkyu4
{
    [TestClass]
    public class SimplexerTest
    {
        [TestMethod]
        public void TestEmpty()
        {
            Simplexer lexer = new Simplexer("");
            Assert.AreEqual(false, lexer.MoveNext());
        }

        [TestMethod]
        public void TestSingle()
        {
            // Identifier
            Simplexer lexer = new Simplexer("x");
            Assert.AreEqual(true, lexer.MoveNext());
            Assert.AreEqual(new Token("x", "identifier"), lexer.Current);

            // Boolean
            lexer = new Simplexer("true");
            Assert.AreEqual(true, lexer.MoveNext());
            Assert.AreEqual(new Token("true", "boolean"), lexer.Current);

            // Integer
            lexer = new Simplexer("12345");
            Assert.AreEqual(true, lexer.MoveNext());
            Assert.AreEqual(new Token("12345", "integer"), lexer.Current);

            // String
            lexer = new Simplexer("\"Hello\"");
            Assert.AreEqual(true, lexer.MoveNext());
            Assert.AreEqual(new Token("\"Hello\"", "string"), lexer.Current);

            // Keyword
            lexer = new Simplexer("break");
            Assert.AreEqual(true, lexer.MoveNext());
            Assert.AreEqual(new Token("break", "keyword"), lexer.Current);

            // Whitespace 
            lexer = new Simplexer("  	");
            Assert.AreEqual(true, lexer.MoveNext());
            Assert.AreEqual(new Token("  	", "whitespace"), lexer.Current);
        }

        [TestMethod]
        public void TestExpression()
        {
            // Simple Expression
            Simplexer lexer = new Simplexer("(1 + 2) - 5");
            CollectionAssert.AreEqual(new Token[]
            {
                new Token("(", "operator"),
                new Token("1", "integer"),
                new Token(" ", "whitespace"),
                new Token("+", "operator"),
                new Token(" ", "whitespace"),
                new Token("2", "integer"),
                new Token(")", "operator"),
                new Token(" ", "whitespace"),
                new Token("-", "operator"),
                new Token(" ", "whitespace"),
                new Token("5", "integer")
            }, ToArray(lexer));
        }

        [TestMethod]
        public void TestStatement()
        {
            // Simple statement
            Simplexer lexer = new Simplexer("return x + 1");
            CollectionAssert.AreEqual(new Token[]
            {
                new Token("return", "keyword"),
                new Token(" ", "whitespace"),
                new Token("x", "identifier"),
                new Token(" ", "whitespace"),
                new Token("+", "operator"),
                new Token(" ", "whitespace"),
                new Token("1", "integer")
            }, ToArray(lexer));
        }

        private Token[] ToArray(Simplexer lexer)
        {
            List<Token> tokens = new List<Token>();
            while (lexer.MoveNext()) tokens.Add(lexer.Current);
            return tokens.ToArray();
        }
    }
}

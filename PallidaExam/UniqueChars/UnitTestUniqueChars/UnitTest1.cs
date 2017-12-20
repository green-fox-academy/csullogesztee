using System;
using NUnit.Framework;
using UniqueChars;
using static UniqueChars.UniqueChars;

namespace UnitTestUniqueChars
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            var unique = new Unique();

            string text = "apple";

            char expected = 'a';
            char output = Unique.UniqueCharacters(text)[0];

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void TestMethod2()
        {
            var unique = new Unique();

            string text = "othertext";

            char expected = 'h';
            char output = Unique.UniqueCharacters(text)[1];

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void TestMethod3()
        {
            var unique = new Unique();

            string text = "Anothervariant";

            char expected = 'A';
            char output = Unique.UniqueCharacters(text)[0];

            Assert.AreEqual(expected, output);
        }
    }
}

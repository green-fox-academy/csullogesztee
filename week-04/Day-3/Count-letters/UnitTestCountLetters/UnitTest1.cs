using System;
using NUnit.Framework;
using Count_letters;
using System.Collections.Generic;

namespace UnitTestCountLetters
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            string trialtest1 = "a";
            var count = new Count();
            var expectedDictionary = new Dictionary<char, int>();
            expectedDictionary.Add('a', 1);

            Assert.AreEqual(expectedDictionary, Count.LetterCounter(trialtest1));
        }
        [Test]
        public void TestMethod2()
        {
            string trialtest2 = "bb";
            var count = new Count();
            var expectedDictionary = new Dictionary<char, int>();
            expectedDictionary.Add('b', 2);

            Assert.AreEqual(expectedDictionary, Count.LetterCounter(trialtest2));
        }
        [Test]
        public void TestMethod3()
        {
            string trialtest3 = "abbccc";
            var count = new Count();
            var expectedDictionary = new Dictionary<char, int>();
            expectedDictionary.Add('a', 1);
            expectedDictionary.Add('b', 2);
            expectedDictionary.Add('c', 3);

            Assert.AreEqual(expectedDictionary, Count.LetterCounter(trialtest3));
        }
    }
}

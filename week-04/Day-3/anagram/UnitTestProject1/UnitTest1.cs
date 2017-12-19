using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram;
using NUnit.Framework;

namespace UnitTestAnagram
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            var anagramcheck = new AnagramCheck();
            string input1 = "asdffdsa";
            string input2 = "asdfasdf";

            bool expected = true;
            bool output = AnagramCheck.AnagramChecker(input1, input2);

            Assert.AreEqual(expected, output);
        }
        [Test]
        public void TestMethod2()
        {
            var anagramcheck = new AnagramCheck();
            string input1 = "asdfAfdsa";
            string input2 = "asdfasdf";

            bool expected = false;
            bool output = AnagramCheck.AnagramChecker(input1, input2);

            Assert.AreEqual(expected, output);
        }
        [Test]
        public void TestMethod3()
        {
            var anagramcheck = new AnagramCheck();
            string input1 = "aaabddd";
            string input2 = "aaacddd";

            bool expected = false;
            bool output = AnagramCheck.AnagramChecker(input1, input2);

            Assert.AreEqual(expected, output);
        }
    }
}

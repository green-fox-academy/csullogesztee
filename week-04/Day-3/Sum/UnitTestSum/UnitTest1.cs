using System;
using NUnit.Framework;
using SumSomeNumber;
using System.Collections.Generic;

namespace UnitTestSum
{
    [TestFixture]
    public class UnitSum
    {       
        [Test]
        public void TestSum1()
        {
            var inputList = new List<int>();
            var sum = new Sum();
            int expected = 0;
            int output = Sum.SumNumbers(inputList);
            Assert.AreEqual(expected, output);
        }
        [Test]
        public void TestSum2()
        {
            var inputList = new List<int>() {5};
            var sum = new Sum();
            int expected = 5;
            int output = Sum.SumNumbers(inputList);
            Assert.AreEqual(expected, output);
        }
        [Test]
        public void TestSum3()
        {
            var inputList = new List<int>() {1, 2, 3, 4, 5};
            var sum = new Sum();
            int expected = 15;
            int output = Sum.SumNumbers(inputList);
            Assert.AreEqual(expected, output);
        }
        [Test]
        public void TestSum4()
        {
            List<int> inputList = null;
            var sum = new Sum();
            int expected = 0;
            int output = Sum.SumNumbers(inputList);
            Assert.AreEqual(expected, output);
        }
    }
}

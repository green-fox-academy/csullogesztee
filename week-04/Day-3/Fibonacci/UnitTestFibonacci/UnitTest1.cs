using System;
using NUnit.Framework;
using Fibonacci;

namespace UnitTestFibonacci
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            var fibonaccinumber = new FibonacciNumber();
            int expected = 2;
            int output = FibonacciNumber.Fibonacci(3);
            Assert.AreEqual(expected, output);
        }
        [Test]
        public void TestMethod2()
        {
            var fibonaccinumber = new FibonacciNumber();
            int expected = 55;
            int output = FibonacciNumber.Fibonacci(10);
            Assert.AreEqual(expected, output);
        }
        [Test]
        public void TestMethod3()
        {
            var fibonaccinumber = new FibonacciNumber();
            int expected = 144;
            int output = FibonacciNumber.Fibonacci(12);
            Assert.AreEqual(expected, output);
        }
    }
}

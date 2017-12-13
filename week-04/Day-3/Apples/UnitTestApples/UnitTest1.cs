using System;
using NUnit.Framework;
using Apples;

namespace UnitTestApples
{
    [TestFixture]
    public class TestApple
    {
        [Test]
        public void TestGetApple()
        {
            var apple = new Apple();
            string output = Apple.GetApple();
            string expected = "apple";
            Assert.AreEqual(expected, output);

        }
    }
}

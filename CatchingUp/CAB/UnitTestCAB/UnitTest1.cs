using System;
using NUnit.Framework;
using CAB;

namespace UnitTestCAB
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestAllSame()
        {
            TheGame game = new TheGame();

            char[] first = { '1', '1', '1', '1' };
            char[] second = { '2', '2', '2', '2' };


            string expected = "[ ][ ][ ][ ]";
            string output = TheGame.GameLogic(first, second);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void TestAllDifferent()
        {
            TheGame game = new TheGame();

            char[] first = { '1', '2', '3', '4' };
            char[] second = { '5', '6', '7', '8' };


            string expected = "[ ][ ][ ][ ]";
            string output = TheGame.GameLogic(first, second);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void TestAllGood()
        {
            TheGame game = new TheGame();

            char[] first = { '1', '2', '3', '4' };
            char[] second = { '1', '2', '3', '4' };


            string expected = "[cow][cow][cow][cow]";
            string output = TheGame.GameLogic(first, second);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void TestAllWrongPlace()
        {
            TheGame game = new TheGame();

            char[] first = { '1', '2', '3', '4' };
            char[] second = { '4', '3', '2', '1' };


            string expected = "[bull][bull][bull][bull]";
            string output = TheGame.GameLogic(first, second);

            Assert.AreEqual(expected, output);
        }
    }
}

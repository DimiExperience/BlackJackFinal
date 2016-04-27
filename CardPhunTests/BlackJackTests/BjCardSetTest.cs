using System;
using BlackJack;
using CardPhun;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Stefan2.BlackJack;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace CardPhunTests.BlackJackTests
{
    [TestClass]
    public class BjCardSetTest
    {
        [TestCase(1, 3, 5)]
        [TestCase(1, 10, 10)]
        [TestCase(11, 10, 10)]//da li je bolje da izdvojim 11 u drugi test pa da proverim "isAce" posebno, ili je ok da bude kao testcase?
        public void GetSumOfCardsTest(int num1, int num2, int num3)
        {
            var actual = num1 + num2 + num3;
            if (num1 == 11)
            {
                actual -= 10;
            }
            var bjCardSet = new BJCardSet();
            var bjCard1 = new BjCard(num1, Znak.CLUBS);
            var bjCard2 = new BjCard(num2, Znak.CLUBS);
            var bjCard3 = new BjCard(num3, Znak.CLUBS);
            bjCardSet.AddToSet(bjCard1);
            bjCardSet.AddToSet(bjCard2);
            bjCardSet.AddToSet(bjCard3);
            Assert.AreEqual(bjCardSet.GetSumOfCards(), actual);
        }
        [TestMethod]
        public void GetSumOfCardsPicTest()
        {
            var actual = 21;
            var bjCardSet = new BJCardSet();
            var bjCard1 = new BjCard(11, Znak.CLUBS);
            var bjCard2 = new BjCard(12, Znak.CLUBS);
            var bjCard3 = new BjCard(13, Znak.CLUBS);
            bjCardSet.AddToSet(bjCard1);
            bjCardSet.AddToSet(bjCard2);
            bjCardSet.AddToSet(bjCard3);
            Assert.AreEqual(bjCardSet.GetSumOfCards(), actual);
        }

        [TestMethod]
        public void GetSumOfCardsBustedTest()
        {
            var bjCardSet = new BJCardSet();
            for (var i = 0; i < 3; i++)
            {
                var bjCard = new BjCard(10, Znak.CLUBS);
                bjCardSet.AddToSet(bjCard);
            }
            Assert.AreEqual(bjCardSet.GetSumOfCards(), -1);
        }
    }
}

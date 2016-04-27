using System;
using BlackJack;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace CardPhunTests.BlackJackTests
{
    [TestClass]
    public class BjGameTest//uh, ovo moram da ostavim za konsultacije sa tobom...
    {
        [TestMethod]
        public void BjGameNumOfDecksTest()//da li se ovo uopste ovako radi????
        {
            var bjGame = new BjGame(1, 1000, "Dealer", "Stefan");
            Assert.Fail();//hmmm, vidids, ovde ne znam sta i kako da radim?? shuffle.......
        }

        [TestMethod]
        public void BjGameBalanceTest()//da li se ovo uopste ovako radi????
        {
            var bjGame = new BjGame(1, 1000, "Dealer", "Stefan");

        }

        [TestMethod]
        public void BjGameDealerTest()
        {
            var bjGame = new BjGame(1, 1000, "Dealer", "Stefan");
            Assert.Fail();
        }

        [TestMethod]
        public void BjGamePlayerTest()
        {
            var bjGame = new BjGame(1, 1000, "Dealer", "Stefan");
            Assert.Fail();
        }

    }
}

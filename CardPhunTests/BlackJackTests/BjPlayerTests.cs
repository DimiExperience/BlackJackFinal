using System;
using System.Security.Authentication.ExtendedProtection;
using BlackJack;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Player;

namespace CardPhunTests.BlackJackTests
{
    [TestClass]
    public class BjPlayerTests
    {
        [TestMethod]
        public void BjPlayerNameTest()
        {
            var bjPlayer = new BjPlayer("Stefan", 1000);
            Assert.AreEqual(bjPlayer.Name, "Stefan");
        }

        [TestMethod]
        public void BjPlayerBalanceTest()
        {
            var bjPlayer = new BjPlayer("Slavko", 1000);
            Assert.AreEqual(bjPlayer.Balance, 1000);
        }

        [TestMethod]
        [ExpectedException(typeof(NegativeBalanceException))]
        public void NegativeBalanceTestThrowsException()
        {
            var newShark = new BjPlayer("Stefan", -500);
        }
    }
}

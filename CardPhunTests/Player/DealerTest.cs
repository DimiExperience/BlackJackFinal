using System;
using BlackJack;
using CardPhun;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Player;
using Stefan2.BlackJack;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace CardPhunTests.Player
{
    [TestClass]
    public class DealerTest
    {
        [TestCase("Stefan")]
        [TestCase("Slavko")]
        [TestCase("Petar Petrovic")]
        public void DealerNameTest(string givenName)
        {
            var newDealer = new NewDealer(givenName);
            Assert.AreEqual(newDealer.Name, givenName);
        }
    }

    public class NewDealer : Dealer<BjCard, BJCardSet>
    {
        public NewDealer(string name) : base(name) { }
    }
}

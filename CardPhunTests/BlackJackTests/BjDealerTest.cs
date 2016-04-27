using System;
using BlackJack;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace CardPhunTests.BlackJackTests
{
    [TestClass]
    public class BjDealerTest
    {
        [TestCase("Stefan")]
        [TestCase("Slavko")]
        [TestCase("Petar Petrovic")]
        public void BjDealerNameTest(string name)//da li je ovo neophodno?
        {
            var bjDealer = new BjDealer(name);
            Assert.AreEqual(bjDealer.Name, name);
        }
    }
}

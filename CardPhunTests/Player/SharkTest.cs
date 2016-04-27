using System;
using System.Linq.Expressions;
using CardPhun;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Player;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace CardPhunTests.Player
{
    [TestClass]
    public class SharkTest
    {
        [TestCase("Stefan", 1000)]
        [TestCase("Slavko", 5000)]
        public void CreateSharkTest(string name, int balance)
        {
            var newShark = new TestShark(name, balance);
            Assert.AreEqual(newShark.Name, name);
            Assert.AreEqual(newShark.Balance, balance);
        }

        [TestMethod]
        [ExpectedException(typeof(NegativeBalanceException))]
        public void NegativeBalanceTestThrowsException()
        {
            var newShark = new TestShark("Stefan", -500);
        }

        [TestMethod]
        [ExpectedException(typeof(NegativeBalanceException))]
        public void NegativeBalanceTest()
        {
            var newShark = new TestShark("Stefan", -500);

    //        Assert.(() => new TestShark("Stefan", -500),
    //Throws.TypeOf<ArgumentException>()
    //    .With.Message.EqualTo("Balance can't be negative!!!"));
        }



    }
}

using System;
using System.Linq.Expressions;
using CardPhun;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
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
        public void NegativeBalanceTest()//Ovaj fail-uje zato sto ne znam kako da napravim throw exception test...
        {
            var newShark = new TestShark("Stefan", -500);// Ovo mi je mnogo konfuzno, kako da napravim test za argument exception?
        }//Ovo fail-uje, dodajem komentar samo da bi se setili...
    }
}

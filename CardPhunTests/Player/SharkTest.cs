using System;
using System.Linq.Expressions;
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
    public class SharkTest
    {
        [TestCase("Stefan", 1000)]
        [TestCase("Slavko", 5000)]
        public void CreateSharkTest(string name, int balance)
        {
            var newShark = new NewShark(name, balance);
            Assert.AreEqual(newShark.Name, name);
            Assert.AreEqual(newShark.Balance, balance);
        }

        [TestMethod]
        public void NegativeBalanceTest()//Ovaj fail-uje zato sto ne znam kako da napravim throw exception test...
        {
            var newShark = new NewShark("Stefan", -500);// Ovo mi je mnogo konfuzno, kako da napravim test za argument exception?
        }//Ovo fail-uje, dodajem komentar samo da bi se setili...
    }

    public class NewShark : Shark<BjCard, BJCardSet>    
    {
        public NewShark(string name, int balance) : base(name, balance)
        {
        }
    }
}

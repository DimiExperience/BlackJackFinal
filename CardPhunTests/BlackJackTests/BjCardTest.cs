using System;
using CardPhun;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Stefan2.BlackJack;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace CardPhunTests.BlackJackTests
{
    [TestClass]
    public class BjCardTest
    {
        [TestCase(Znak.DIAMONDS, 12)]
        [TestCase(Znak.HEARTS, 13)]
        [TestCase(Znak.SPADES, 14)]
        public void BjCardValuePicTest(Znak znak, int num)
        {
            var bjCard = new BjCard(num, znak);
            Assert.AreEqual(bjCard.Value, 10);
        }

        [TestCase(Znak.CLUBS)]
        [TestCase(Znak.DIAMONDS)]
        [TestCase(Znak.HEARTS)]
        [TestCase(Znak.SPADES)]
        [Repeat(1000)]//ovde mi ustvari ne treba testcase za svaki znak, posto proveravam samo broj, right? ili da ostavim da bih video kako se ponasa sa svakim znakom?
        public void CardCreateNumberTest(Znak varZnak)
        {
            var random = new Random();
            var broj = random.Next(1, 12);
            var bjCard = new BjCard(broj, varZnak);
            Assert.AreEqual(bjCard.Number, broj, "Actual number and given number !=");
        }
    }
}

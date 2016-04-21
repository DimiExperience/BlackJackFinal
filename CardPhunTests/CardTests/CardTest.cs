using System;
using CardPhun;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Stefan2.BlackJack;
using Stefan2;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace CardPhunTests
{
    [TestClass]
    public class CardTest
    {
        [TestCase(Znak.CLUBS)]
        [TestCase(Znak.DIAMONDS)]
        [TestCase(Znak.HEARTS)]
        [TestCase(Znak.SPADES)]
        [Repeat(1000)]//ovde mi ustvari ne treba testcase za svaki znak, posto proveravam samo broj, right? ili da ostavim da bih video kako se ponasa sa svakim znakom?
        public void CardCreateNumberTest(Znak varZnak)
        {
            var random = new Random();
            var broj = random.Next(1, 15);
            var newCard = new TestCard(broj, varZnak);
            Assert.AreEqual(newCard.Number, broj, "Actual number and given number !=");
        }

        [TestCase(Znak.CLUBS)]
        [TestCase(Znak.DIAMONDS)]
        [TestCase(Znak.HEARTS)]
        [TestCase(Znak.SPADES)]
        [Repeat(1000)]//isto pitanje i ovde u vezi znaka?
        public void CardCreateValueTest(Znak varZnak)
        {
            var random = new Random();
            var broj = random.Next(1, 15);
            var newCard = new TestCard(broj, varZnak);
            Assert.AreEqual(newCard.Value, broj, "Converting number to Value failed");
        }

        [TestCase(Znak.CLUBS)]
        [TestCase(Znak.DIAMONDS)]
        [TestCase(Znak.HEARTS)]
        [TestCase(Znak.SPADES)]
        [Repeat(1000)]//a ovde proveravam znak, pa sada, da li treba da izbacim broj, zadam tipa 1, ili da ostavim da vidim jel se ponasa dobro sa svim brojevima?
        public void CardCreateSuitTest(Znak varZnak)
        {
            var random = new Random();
            var broj = random.Next(1, 15);
            var newCard = new TestCard(broj, varZnak);
            Assert.AreEqual(newCard.Suit, varZnak, "Suit doesnt assign properly");
        }

        [TestMethod]
        public void IsAceTest()
        {
            var newCard = new TestCard(11, Znak.CLUBS);
            //e vidis, ne znam kako ovo da odradim...       
        }
    }
}

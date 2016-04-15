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
        [Repeat(10000)]
        public void CardCreateTest(Znak varZnak)
        {
            var random = new Random();
            var broj = random.Next(1, 15);
            var newCard = new TestCard(broj, varZnak);
            Assert.AreEqual(newCard.Number, broj);
            Assert.AreEqual(newCard.Value, broj);
            Assert.AreEqual(newCard.Suit, varZnak);
        }
    }

    class TestCard : Card   //posto je klasa bila abstract, 
                            //napravio sam jednu ovde klasu koja 
                            //nasledjuje sve onako kako jeste, i onda iz nje vucem...
    {
        public TestCard(int number, Znak suit) : base(number, suit)
        {
        }

        public override int Value
        {
            get
            {
                return Number;
            }
        }
    }
}

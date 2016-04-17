using System;
using System.Linq;
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
        //NewDealer newDealer = new NewDealer("Stefan");//ovde mi ne da da stavim var na pocetku, o tome sam ti pricao pre par nedelja...


        [TestCase("Stefan")]
        [TestCase("Slavko")]
        [TestCase("Petar Petrovic")]
        public void DealerNameTest(string givenName)
        {
            var namedDealer = new NewDealer(givenName);
            Assert.AreEqual(namedDealer.Name, givenName);
        }

        [TestMethod]
        public void CardsEmptyTest()
        {
            var newDealer = new NewDealer("Stefan");//e sada, posto koristim dealera koji je nebitno kako se zove 2 puta, da li treba da napravim na pocetku jedan, pa da ga koristim, jedino sto u jednom ima u drugom testu nema karte... jel kada napravim sa gore instancom dealera, on mi cita da u prvom testu ima karte...
            var cardCount = newDealer.Cards.Count;
            Assert.AreEqual(cardCount, 0);
        }

        [TestMethod]
        public void CardsDealtTest()
        {
            var newDealer = new NewDealer("Slacko");
            var card = new TestCard(1, Znak.CLUBS);
            newDealer.Cards.AddToSet(card);
            var cardCount = newDealer.Cards.Count;
            Assert.AreEqual(cardCount, 1);
        }

    }

    public class NewDealer : Dealer<TestCard, TestCardSet>
    {
        public NewDealer(string name) : base(name) { }
    }

    public class TestCard : Card
    {
        public TestCard(int number, Znak suit) : base(number, suit)
        {
        }
        public override int Value
        {
            get { return Number; }
        }
    }

    public class TestCardSet : CardSet<TestCard>
    {
        public override int GetSumOfCards()
        {
            int retVal = _mCards.Sum(card => card.Value);//e sada, ovo sam odradio copy/paste, aj da popricamo o ovome kada dodjem...
            return retVal;
        }
    }
}

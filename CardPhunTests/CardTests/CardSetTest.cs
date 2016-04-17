using System;
using System.Linq;
using CardPhun;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CardPhunTests.CardTests
{
    [TestClass]
    public class CardSetTest
    {
        [TestMethod]
        public void AddToSetCountTest()
        {
            var card = new TestCard(1, Znak.CLUBS);
            var cardSet = new TestCardSet();
            cardSet.AddToSet(card);
            Assert.AreEqual(cardSet.Count, 1);
        }

        [TestMethod]
        public void AddToSetNumberTest()
        {
            var card = new TestCard(1, Znak.CLUBS);
            var cardSet = new TestCardSet();
            cardSet.AddToSet(card);
            Assert.AreEqual(cardSet.GetSumOfCards(), 1);//da li sam ovim proverio getsumofcards, ili to moram posebno kada dodjem do toga?
        }

        [TestMethod]
        public void SeeCardTest()
        {
            var card = new TestCard(1, Znak.CLUBS);
            var cardSet = new TestCardSet();
            cardSet.AddToSet(card);
            Assert.AreEqual(cardSet.SeeCard(0).ToString(), "1 CLUBS");
        }

        [TestMethod]
        public void ShuffleTest()
        {
            var cardSet = new TestCardSet();
            var shuffledCardSet = new TestCardSet();
            for (var i = 0; i < 10; i++)
            {
                var card = new TestCard(i+1, Znak.CLUBS);
                cardSet.AddToSet(card);
                shuffledCardSet.AddToSet(card);
            }
            shuffledCardSet.Shuffle();
            Assert.AreNotEqual(shuffledCardSet, cardSet);

        }

        [TestMethod]
        public void CountTest()
        {
            var cardSet = new TestCardSet();
            int actualCount = 0;
            for (var i = 0; i < 10; i++)
            {
                var card = new TestCard(i+1, Znak.CLUBS);
                cardSet.AddToSet(card);
                actualCount += 1;
            }
            Assert.AreEqual(cardSet.Count, actualCount);

        }

        [TestMethod]
        public void PopFromSetTest()
        {
            var cardSet = new TestCardSet();
            var card = new TestCard(1, Znak.CLUBS);
            cardSet.AddToSet(card);
            cardSet.PopFromSet(true);
            Assert.AreEqual(cardSet.Count, 0);
        }

        [TestMethod]
        public void AddSetTest()
        {
            var firstSet = new TestCardSet();
            var secondSet = new TestCardSet();
            for (var i = 0; i < 10; i++)
            {
                var card = new TestCard(i + 1, Znak.CLUBS);
                firstSet.AddToSet(card);
            }
            secondSet.AddSet(firstSet);
            Assert.AreEqual(secondSet.ToString(), firstSet.ToString());//e vidis, kada sam stavio samo areequal, nije radilo, kada sam dodao tostring(), proradilo, ZASTO?
        }

        [TestMethod]
        public void GetCardListTest()//ne znam sta sam i zasto ovde radio, ali pogledati...
        {
            var firstSet = new TestCardSet();
            var secondSet = new TestCardSet();
            for (var i = 0; i < 10; i++)
            {
                var card = new TestCard(i + 1, Znak.CLUBS);
                firstSet.AddToSet(card);
            }
            secondSet.AddSet(firstSet);
            Assert.AreEqual(secondSet.GetCardList().ToString(), firstSet.GetCardList().ToString());//e vidis, kada sam stavio samo areequal, nije radilo, kada sam dodao tostring(), proradilo, ZASTO?
        }

        [TestMethod]
        public void ToStringOverrideTest()
        {
            var cardSet = new TestCardSet();
            for (var i = 0; i < 3; i++)
            {
                var card = new TestCard(i + 1, Znak.CLUBS);
                cardSet.AddToSet(card);
            }
            Assert.AreEqual(cardSet.ToString(), "1 CLUBS, 2 CLUBS, 3 CLUBS");//HA, e vidis, nasao sam gresku preko testova:P i popravio
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

    public class TestCard : Card 
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

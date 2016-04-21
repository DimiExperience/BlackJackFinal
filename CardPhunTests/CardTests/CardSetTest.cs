using System;
using CardPhun;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

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
            var initialCount = cardSet.Count;
            cardSet.AddToSet(card);
            var finalCount = cardSet.Count;
            Assert.AreEqual(finalCount - initialCount, 1);
        }

        [TestMethod]
        [Repeat(100)]//s' obzirom da sam svatio random, onda ga proveravam vise puta? tako mi deluje logicno, bar u ovom slucaju...
        public void GetSumOfCardsTest()//E sada, ja sam napravio dva testa koja rade slicne stvari, da li mora tako ili sam mogao da ostavim jedan i da mu verujem:) posto proveravaju vrlo slicnu stvar...
        {
            var cardSet = new TestCardSet();
            var random = new Random();
            var actualCount = 0;
            for (var i = 0; i < 5; i++)
            {
                var cardNumber = random.Next(1, 15);
                var card = new TestCard(cardNumber, Znak.CLUBS);
                cardSet.AddToSet(card);
                actualCount += cardNumber;
            }
            Assert.AreEqual(cardSet.GetSumOfCards(), actualCount);
        }

        [TestMethod]
        [Repeat(100)]//ista prica kao i u prethodnom...
        public void AddToSetNumberTest()//ovo je drugi test na koji sam mislio u prethodnom komentaru...
        {
            var cardSet = new TestCardSet();
            var random = new Random();
            var cardSetString = "";
            for (var i = 0; i < 5; i++)
            {
                var cardNumber = random.Next(1, 15);
                var card = new TestCard(cardNumber, Znak.CLUBS);
                cardSet.AddToSet(card);
                cardSetString = cardSetString + card + ", ";
            }
            Assert.AreEqual(cardSet.ToString(), cardSetString.TrimEnd(',', ' '));
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
            var maxCount = 10;
            for (var i = 0; i < maxCount; i++)
            {
                var card = new TestCard(i+1, Znak.CLUBS);
                cardSet.AddToSet(card);
            }
            Assert.AreEqual(cardSet.Count, maxCount);

        }

        [TestMethod]
        public void PopFromSetTest()//dodaj 10 karata, oduzmi 3, 7...
        {
            var cardSet = new TestCardSet();
            var card = new TestCard(1, Znak.CLUBS);
            cardSet.AddToSet(card);
            cardSet.PopFromSet(true);
            Assert.Fail("Odradi ovaj test");
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
            //ako bih ispred secondSet stavio (object), koristio bi default tostring()!!! ovo je komentar za mene, a ne pitanje:P
            Assert.AreEqual(secondSet.ToString(), firstSet.ToString());
        }

        [TestMethod]
        public void GetCardListTest()//ovde mi nisi napisao da li je ovo ok?
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
}

using System;
using BlackJack;
using CardPhun;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Stefan2.BlackJack;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace CardPhunTests.BlackJackTests
{
    [TestClass]
    public class BlackJackUtilTest//e vidis, ovo mi se bas svidja:) sada sam provali da kada je busted ne vraca -1, i onda sam promenio to u klasi, i posto sam imao testove za sve ostalo, vidim da nisam nista sjebao... pocinjem da kontam koliko su bitni testovi:)
    {
        [TestCase(1, 3, 5)]
        [TestCase(1, 10, 10)]
        [TestCase(11, 10, 10)]
        public void GetBlackjackSumTest(int num1, int num2, int num3)//ova klasa se nigde nije koristila, posto to ima vec u bjcardset-u, ali cisto radi vezbe da je testiram:)
        {
            var bjCardSet = new BJCardSet();
            var actual = num1 + num2 + num3;
            if (num1 == 11)
            {
                actual -= 10;
            }
            var bjCard1 = new BjCard(num1, Znak.CLUBS);
            var bjCard2 = new BjCard(num2, Znak.CLUBS);
            var bjCard3 = new BjCard(num3, Znak.CLUBS);
            bjCardSet.AddToSet(bjCard1);
            bjCardSet.AddToSet(bjCard2);
            bjCardSet.AddToSet(bjCard3);
            var expected = BlackJackUtil.GetBlackjackSum(bjCardSet);//s' obzirom da mi je ovo line koji nije neophodan, jel bolje ovako, ili samo da stavim dole u assert bez zadavanja variable??
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetBlackjackSumPicTest()
        {
            var actual = 21;
            var bjCardSet = new BJCardSet();
            var bjCard1 = new BjCard(11, Znak.CLUBS);
            var bjCard2 = new BjCard(12, Znak.CLUBS);
            var bjCard3 = new BjCard(13, Znak.CLUBS);
            bjCardSet.AddToSet(bjCard1);
            bjCardSet.AddToSet(bjCard2);
            bjCardSet.AddToSet(bjCard3);
            Assert.AreEqual(BlackJackUtil.GetBlackjackSum(bjCardSet), actual);//na ovo sam mislio, da li je bolje skratiti line koda i ostaviti ovako?
        }

        [TestMethod]
        public void GetBlackjackSumBustedTest()
        {
            var bjCardSet = new BJCardSet();
            for (var i = 0; i < 3; i++)
            {
                var bjCard = new BjCard(10, Znak.CLUBS);
                bjCardSet.AddToSet(bjCard);
            }
            Assert.AreEqual(BlackJackUtil.GetBlackjackSum(bjCardSet), -1);//e vidis, ovo fail-uje, tako da eto ti greske, pa sam dodao metod u klasi i popravio:)
        }

    }
}

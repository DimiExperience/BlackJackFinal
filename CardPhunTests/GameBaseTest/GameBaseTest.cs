using System;
using BlackJack;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Player;
using Stefan2.BlackJack;

namespace CardPhunTests.GameBaseTest
{
    [TestClass]
    public class GameBaseTest
    {
        [TestMethod]
        public void AddPlayerTest()
        {
            var gameBase = new TestGameBase();
            gameBase.AddPlayer;//zasto ne mogu da pristupim protected method-u?
        }
    }
}

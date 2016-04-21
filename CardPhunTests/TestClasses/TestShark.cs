using BlackJack;
using CardPhunTests.CardTests;
using Player;
using Stefan2.BlackJack;

namespace CardPhunTests.Player
{
    public class TestShark : Shark<TestCard, TestCardSet>    
    {
        public TestShark(string name, int balance) : base(name, balance)
        {
        }
    }
}
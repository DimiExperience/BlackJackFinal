using CardPhunTests.CardTests;
using Player;

namespace CardPhunTests.Player
{
    public class TestDealer : Dealer<TestCard, TestCardSet>
    {
        public TestDealer(string name) : base(name) { }
    }
}
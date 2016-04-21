using System.Linq;
using CardPhun;

namespace CardPhunTests.CardTests
{
    public class TestCardSet : CardSet<TestCard>
    {
        public override int GetSumOfCards()
        {
            int retVal = _mCards.Sum(card => card.Value);//e sada, ovo sam odradio copy/paste, aj da popricamo o ovome kada dodjem...
            return retVal;
        }
    }
}
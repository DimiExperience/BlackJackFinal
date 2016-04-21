using CardPhun;

namespace CardPhunTests
{
    public class TestCard : Card   //posto je klasa bila abstract, 
        //napravio sam jednu ovde klasu koja 
        //nasledjuje sve onako kako jeste, i onda iz nje vucem...
    {
        public TestCard(int number, Znak suit) : base(number, suit)
        {
        }

        public TestCard()
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
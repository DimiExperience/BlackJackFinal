using System;
using CardPhun;
using Stefan2;

namespace Player
{
    public abstract class Shark<T_CARD, T_CARDSET> : Dealer<T_CARD, T_CARDSET>
        where T_CARD : Card
        where T_CARDSET : CardSet<T_CARD>, new()
    {
        protected Shark(string name, int balance) : base(name)
        {
            Balance = balance;

            if (balance < 0)
            {
                throw new NegativeBalanceException("Balance can't be negative");//ovo ne znam kako da testiram
            }
        }
        public int Balance { get; protected set; }

    }

    public class NegativeBalanceException : Exception
    {
        public string BaseMessage => base.Message;
        public string CustomMessage { get; set; }

        public NegativeBalanceException(string message)
        {
            this.CustomMessage = message;
        }
    }

}
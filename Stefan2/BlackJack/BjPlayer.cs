using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Player;
using Stefan2.BlackJack;

namespace BlackJack
{
    public class BjPlayer : Shark<BjCard, CardSet>
    {
        public BjPlayer(string name, int balance) : base(name, balance)
        {
        }
    }
}

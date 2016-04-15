using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Player;
using Toore.Shuffling;

namespace BlackJack
{
    class Program
    {
         private static void Main(string[] args)
        {
             BjGame newGame = new BjGame(1, 100, "Dealer", "Stefan"); //bilo mi dosadno u busu, pa sam gledao projekat, koliko vidim, big o moze da se smanji dosta, right?
             newGame.Play();
        }
    }
}

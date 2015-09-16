﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardPhun
{
    public class CardDeck : CardSet
    {
        public CardDeck(bool shuffleIt = true) //Constructor. Executes when you make a new instance (object) of this class.
        {
            for (int i = 2; i <= 14; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    var znak = (Znak)j;
                    var karta = new Card(i, znak);
                    AddToSet(karta);
                }
            }
            if (shuffleIt)
            {
                Shuffle();
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Card
    {
        public string stringVal;
        public string suit;
        public string val;
        public Card(string stringVal, string suit, int val)
        {
            this.stringVal = stringVal;
            this.suit = suit;
            this.val = val;
        }
    }
}

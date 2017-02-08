using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Card
    {
        public string stringVal;
        public string suit;
        public int val;
        public string fullName;
        public Card(string suit, int val)
        {
            this.suit = suit;
            this.val = val;
            this.stringVal = getStringVal(val);
            this.fullName = this.stringVal + " of " + this.suit; // Ace of Spades
        }

        string getStringVal(int val)
        {
            if (val == 1) { return "Ace"; }
            else if (val == 2)  { return "Two"; }
            else if (val == 3)  { return "Three"; }
            else if (val == 4)  { return "Four"; }
            else if (val == 5)  { return "Five"; }
            else if (val == 6)  { return "Six"; }
            else if (val == 7)  { return "Seven"; }
            else if (val == 8)  { return "Eight"; }
            else if (val == 9)  { return "Nine"; }
            else if (val == 10) { return "Ten"; }
            else if (val == 11) { return "Jack"; }
            else if (val == 12) { return "Queen"; }
            else if (val == 13) { return "King"; }
            else { return "???"; }
        }
    }
}

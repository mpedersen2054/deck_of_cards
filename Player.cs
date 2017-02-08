using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Player
    {
        public string name;
        public List<Card> hand;
        public Player(string name = "No Name")
        {
            this.name = name;
            this.hand = new List<Card>();
        }
        public Card Draw(Deck deck)
        {
            Card newCard = deck.Deal();
            this.hand.Add(newCard);
            return newCard;
        }

        public object Discard(int desiredIdx)
        {
            try {
                Card card = this.hand[desiredIdx];
                return card;
            } catch { return null; }
        }
    }
}

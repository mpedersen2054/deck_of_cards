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
            //Same idea with the "this" reference, not always needed in C#
            //However in this case where you have 2 similar variable names with different scopes
            //using this to distingush which version you are working with is good
            this.name = name;
            hand = new List<Card>();
        }
        public Card Draw(Deck deck)
        {
            Card newCard = deck.Deal();
            hand.Add(newCard);
            return newCard;
        }

        public Card Discard(int desiredIdx)
        {
            //Awesome
            try {
                Card card = hand[desiredIdx];
                hand.RemoveAt(desiredIdx);
                return card;
            } catch { return null; }
        }
    }
}

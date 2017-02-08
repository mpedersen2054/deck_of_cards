using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Deck
    {
        Random rand = new Random();
        string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
        public List<Card> cards = new List<Card>();
        
        public Deck()
        {
            // iterate over each suit
            foreach (string suit in suits)
            {
                // another loop for each card per suit
                for (int i = 1; i < 14; i++)
                {
                    cards.Add(new Card(suit, i));
                }
            }
        }

        public void Shuffle()
        {
            // List<Card> oldCards = cards;
            // this.cards = null;
            for (int i = 0; i < this.cards.Count; i++)
            {
                Card currCard = this.cards[i];
                this.cards.RemoveAt(i);
                
                int newIdx = rand.Next(0, this.cards.Count);
                this.cards.Insert(newIdx, currCard);
            }

            foreach (Card card in this.cards)
            {
                System.Console.WriteLine(card.fullName);
            }
        }
    }
}

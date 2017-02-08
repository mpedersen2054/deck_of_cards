using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Deck
    {
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
            foreach (Card card in cards)
            {
                System.Console.WriteLine(card.fullName);
            }
        }
    }
}

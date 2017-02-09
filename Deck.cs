using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Deck
    {
        Random rand = new Random();
        string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };

        //Since the first thing the reset method does is assign our List of cards
        //to a new List, then we don't need to assign it out here
        public List<Card> cards; // = new List<Card>();
        
        public Deck()
        {
            //This isn't Javascript, no need for constant "this" reference for Class scoped variables
            ResetDeck();
        }
        public void GetDeckLen()
        {
            System.Console.WriteLine(cards.Count);
        }

        public void Shuffle()
        {
            // loop over each card, remove it, insert it into
            // a random 0-51 index of this.cards
            for (int i = 0; i < cards.Count; i++)
            {
                //Remove and insert are doing a lot of extra work!
                //Each time you run either method you have a good amount going on in the background
                //Instead probably just swap the values at each index

                // select card and remove it from list
                // Card currCard = this.cards[i];
                // this.cards.RemoveAt(i);
                // insert currCard[rand 0-51]
                int newIdx = rand.Next(0, cards.Count);
                // this.cards.Insert(newIdx, currCard);

                //swap
                Card temp = cards[i];
                cards[i] = cards[newIdx];
                cards[newIdx] = temp;
            }

            // // print out each card
            // foreach (Card card in this.cards)
            // {
            //     System.Console.WriteLine(card.fullName);
            // }
        }

        public Card Deal()
        {
            // select the top card, remove it and return it
            int topIdx = cards.Count - 1;
            Card topCard = cards[topIdx];
            cards.RemoveAt(topIdx);
            return topCard;
        }

        public void ResetDeck()
        {
            cards = new List<Card>();
            // iterate over each suit
            foreach (string suit in suits)
            {
                // another loop for each card per suit
                for (int i = 1; i < 14; i++)
                {
                    cards.Add(new Card(suit, i));
                }
            }

            // print out each card in new deck & deck.Count
            foreach (Card card in cards)
            {
                System.Console.WriteLine(card.fullName);
            }
            System.Console.WriteLine("Cards in deck: {0}", cards.Count);
        }

    }
}

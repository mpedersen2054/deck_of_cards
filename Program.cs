using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Shuffle();
            // Card p1 = deck.Deal();
            // Card p2 = deck.Deal();
            // Card d1 = deck.Deal();
            // Card d2 = deck.Deal();
            // System.Console.WriteLine("Player card {0}", p1.fullName);
            // System.Console.WriteLine("Player card {0}", p2.fullName);
            // System.Console.WriteLine("Dealer card {0}", d1.fullName);
            // System.Console.WriteLine("Dealer card {0}", d2.fullName);

            Player matt = new Player("Matt");
            Player dealer = new Player("Dealer");
            // System.Console.WriteLine(matt.name);

            // deck.ResetDeck();
            deck.Shuffle();
            matt.Draw(deck);
            matt.Draw(deck);
            dealer.Draw(deck);
            dealer.Draw(deck);
            deck.GetDeckLen();

            for (int i = 0; i < matt.hand.Count; i++)
            {
                System.Console.WriteLine("Matt: {0}", matt.hand[i].fullName);
                System.Console.WriteLine("Dealer: {0}", dealer.hand[i].fullName);
            }

            object mattcard = matt.Discard(2);
            // System.Console.WriteLine(mattcard);
            if (mattcard is Card)
            {
                Card mattcard1 = (Card)mattcard;
                System.Console.WriteLine(mattcard1.fullName);
            }
            else
            {
                System.Console.WriteLine("Card doesnt exist");
            }
            
            
        }
    }
}

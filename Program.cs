using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Shuffle();
            Card p1 = deck.Deal();
            Card p2 = deck.Deal();
            Card d1 = deck.Deal();
            Card d2 = deck.Deal();
            System.Console.WriteLine("Player card {0}", p1.fullName);
            System.Console.WriteLine("Player card {0}", p2.fullName);
            System.Console.WriteLine("Dealer card {0}", d1.fullName);
            System.Console.WriteLine("Dealer card {0}", d2.fullName);

            deck.ResetDeck();
            // deck.Shuffle();
        }
    }
}

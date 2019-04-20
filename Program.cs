using System;
using System.Collections.Generic;
using Cards.Custom;

namespace Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Card troyCard = new Card();
            troyCard.ModStringVal = "Ace of Spades";
            Console.WriteLine(troyCard.ModStringVal);
            Deck troyDeck = new Deck();
            troyDeck.Shuffle();

            Player troy = new Player("Troy");
            troy.Draw(troyDeck);


            Console.WriteLine(troyDeck.Deal());

            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardClassLibrary;

namespace CardDeckTests
{
    class CardDeckTest
    {
        static void Main(string[] args)
        {
            // TestCardDeckAll();

            TestCardDeckConstructor();
            TestCardDeckShuffle();
            // TestCardDeckDeal()
            // TestCardDeckIsEmpty()
            // TestCardDeckToString();

            Console.WriteLine();
            Console.ReadLine();
        }

        static void TestCardDeckConstructor()
        {
            CardDeck cDeck = new CardDeck();

            Console.WriteLine("Testing constructor");
            Console.WriteLine("Default constructor. Expecting count of 52 " + cDeck.NumCards);
            Console.WriteLine("Default constructor. Expecting list of 52 cards \n" + cDeck);
        }

        static void TestCardDeckShuffle()
        {
            CardDeck cDeck = new CardDeck();
            cDeck.ShuffleCards();

            Console.WriteLine("Testing shuffle method");

            Console.WriteLine("Shuffle method. Expecting shuffled list of 52 cards \n" + cDeck);
        }
    }
}

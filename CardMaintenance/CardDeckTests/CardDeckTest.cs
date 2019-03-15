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

            TestCardDeckConstructor();
            TestCardDeckNumCards();
            TestCardDeckShuffle();
            TestCardDeckDeal();
            TestCardDeckIsEmpty();
            TestCardDeckToString();

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

        static void TestCardDeckNumCards()
        {
            CardDeck cDeck = new CardDeck();

            Console.WriteLine("Testing numcards carddeck count property");
            Console.WriteLine("Expecting 52 " + cDeck.NumCards);
        }

        static void TestCardDeckShuffle()
        {
            CardDeck cDeck = new CardDeck();
            cDeck.ShuffleCards();

            Console.WriteLine("Testing shuffle method");

            Console.WriteLine("Shuffle method. Expecting shuffled list of 52 cards \n" + cDeck);
            Console.WriteLine();
        }

        static void TestCardDeckDeal()
        {
            CardDeck cDeck = new CardDeck();

            Console.WriteLine("Testing deal method");
            Card dealt = cDeck.DealCard();
            Console.WriteLine("Dealing 1 card. Expecting ace of clubs " + dealt);
            Console.WriteLine("Dealt 1 card. Expecting carddeck numcards of 51 " + cDeck.NumCards);

            Console.WriteLine();
        }

        static void TestCardDeckIsEmpty()
        {
            CardDeck cDeck = new CardDeck();

            Console.WriteLine("Testing Is Empty method");
            Console.WriteLine("IsEmpty method performed on full deck. Expecting False " + cDeck.IsEmpty());

            for (int i = cDeck.NumCards; i > 0; i--)
            {
                cDeck.DealCard();
            }

            Console.WriteLine("IsEmpty method performed on empty deck. Expecting True " + cDeck.IsEmpty());
            Console.WriteLine(cDeck);
        }

        static void TestCardDeckToString()
        {
            CardDeck cDeck = new CardDeck();

            Console.WriteLine("Testing to string method");
            Console.WriteLine("Expecting list of 52 cards \n" + cDeck.ToString());
        }
    }
}

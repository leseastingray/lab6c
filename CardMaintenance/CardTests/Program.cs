using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardClassLibrary;


namespace CardTests
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestCardConstructors();

            Card aS = new Card(1, 4);
            Card qH = new Card(12, 3);
            Card tD = new Card(2, 2);

            //TestCardIsMethods(aS);
            //TestCardIsMethods(qH);

            // Hand Class Tests
            TestHandNumber();
            TestHandAddAndDiscard();
            TestHandIndexers();
            TestHandBoolMethods();
            // BlackJack Hand Tests
            TestBlackJackHand();

            Console.WriteLine();
            Console.ReadLine();

        }

        // Test Card Constructors
        static void TestCardConstructors()
        {
            Card card1 = new Card();
            Card card2 = new Card(12, 3);

            Console.WriteLine("Testing Constructors");
            Console.WriteLine("Default constructor. Expecting default values. " + card1.ToString() + ".");
            Console.WriteLine("Overloaded constructor. Expecting queen of hearts. " + card2.ToString() + ".");
            Console.WriteLine();
        }

        // Test Card ToString Method
        static void TestCardToString(Card card)
        {
            Console.WriteLine("Testing toString Method");
            Console.WriteLine("The card is " + card.ToString() + ".");
            Console.WriteLine();
        }

        // Test Card IsMethods
        static void TestCardIsMethods(Card card)
        {
            Console.WriteLine("Testing Is Methods");
            Console.WriteLine("The card is " + card.ToString() + ".");
            Console.WriteLine();

            if (card.IsHeart())
                Console.WriteLine("The card is a heart.");
            else
                Console.WriteLine("The card is not a heart.");
            Console.WriteLine();

            if (card.IsFaceCard())
                Console.WriteLine("The card is a face card");
            else
                Console.WriteLine("The card is not a face card.");
            Console.WriteLine("");

            if (card.IsQueen())
                Console.WriteLine("The card is a queen.");
            else
                Console.WriteLine("The card is not a queen.");
            Console.WriteLine();

            if (card.IsBlack())
                Console.WriteLine("The card is black.");
            else
                Console.WriteLine("The card is not black.");
        }

        // Test Hand Count Property
        static void TestHandNumber()
        {
            Console.WriteLine("Hand Class Tests");
            Hand handCards = new Hand();
            int number = handCards.NumCards;

            Console.WriteLine("Testing NumCards Property");
            Console.WriteLine("Expecting count of 0: " + number);
            Console.WriteLine();

        }

        // Test Add and Discard Methods
        static void TestHandAddAndDiscard()
        {
            Hand handCards = new Hand();
            Card card1 = new Card();
            Card card2 = new Card(12, 3);

            Console.WriteLine("Testing Hand Add Card Method");
            handCards.Add(card1);
            handCards.Add(card2);
            Console.WriteLine("Expecting count of 2: " + handCards.NumCards);
            Console.WriteLine("Expecting ace of clubs queen of hearts: " + handCards);
            Console.WriteLine();

            Console.WriteLine("Testing Hand Discard Method");
            handCards.Discard(card1);
            Console.WriteLine("Expecting count of 1: " + handCards.NumCards);
            Console.WriteLine("Expecting queen of hearts: " + handCards);
            Console.WriteLine();
        }

        static void TestHandIndexers()
        {
            Hand handCards = new Hand();
            Card card1 = new Card();
            Card card2 = new Card(12, 3);
            Card card3 = new Card(2, 2);
            handCards.Add(card1);
            handCards.Add(card2);
            handCards.Add(card3);

            Console.WriteLine("Testing indexer");
            Console.WriteLine("Get card at index 0");
            Card index0card = handCards[0];
            Console.WriteLine("Expecting ace of clubs: " + index0card);

            Console.WriteLine("Testing index by value");

            Card index2valcard= handCards.IndexOf(2);
            Console.WriteLine("Getting card with value of 2");
            Console.WriteLine("Expecting 2 of diamonds: " + index2valcard);
            Console.WriteLine();
        }

        static void TestHandBoolMethods()
        {
            Hand handCards = new Hand();
            Card card1 = new Card();
            Card card2 = new Card(12, 3);
            Card card3 = new Card(2, 2);
            handCards.Add(card1);
            handCards.Add(card2);
            handCards.Add(card3);

            Console.WriteLine("Testing HasCard(card) Bool");
            Console.WriteLine("Has queen of hearts? Expecting True: " + handCards.HasCard(card2));
            Console.WriteLine("Testing HasCard(value) Bool");
            Console.WriteLine("Has card with value of 4? Expecting False: " + handCards.HasCard(4));
            Console.WriteLine("Testing HasCard(value, suit) Bool");
            Console.WriteLine("Has card with value of 2, diamonds suit? Expecting True: "
                 + handCards.HasCard(2, 2));
            Console.WriteLine();
        }

        // BlackJackHand Tests
        static void TestBlackJackHand()
        {
            BJHand bJHandCards = new BJHand();
            Card card1 = new Card();
            Card card2 = new Card(12, 3);
            Card card3 = new Card(2, 2);
            Card card4 = new Card(11, 1);

            Console.WriteLine("Testing BJHand Score");
            bJHandCards.Add(card3);
            bJHandCards.Add(card4);
            Console.WriteLine("Expecting score of 12: " + bJHandCards.Score);

            Console.WriteLine("Testing BJHand HasAce Method");
            Console.WriteLine("Expecting False: " + bJHandCards.HasAce());
            bJHandCards.Discard(card2);
            bJHandCards.Add(card1);
            Console.WriteLine("Expecting True: " + bJHandCards.HasAce());

            Console.WriteLine("Testing BJHand IsBusted Method");
            Console.WriteLine("Expecting False: " + bJHandCards.IsBusted());
            bJHandCards.Discard(card3);
            bJHandCards.Add(card4);
            Console.WriteLine("Expecting False: " + bJHandCards.IsBusted());
            bJHandCards.Add(card2);
            Console.WriteLine("Expecting True: " + bJHandCards.IsBusted());

        }
    }
}

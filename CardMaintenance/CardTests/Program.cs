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
            TestCardConstructors();

            Card aS = new Card(1, 4);
            Card qH = new Card(12, 3);

            TestCardIsMethods(aS);
            TestCardIsMethods(qH);

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
    }
}

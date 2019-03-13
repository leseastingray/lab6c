using System;
using System.Collections.Generic;
using System.Text;

namespace CardClassLibrary
{
    public class CardDeck
    {
        // instance variable
        private List<Card> cards;

        // Default constructor
        public CardDeck()
        {
            cards = new List<Card>();

        }

        // Count property
        public int NumCards
        {
            get
            {
                return cards.Count;
            }
        }

        // CardDeck Methods
        // ShuffleCards
        public void ShuffleCards()
        {
            Random generator = new Random();

            for (int i = 1; i <= 20; i++)
            {
                int randomIndex = generator.Next(1, 21);
                Card temp = cards[i];
                cards[i] = cards[randomIndex];
                cards[randomIndex] = temp;
            }
        }
        // DealCard
        // Remove index 0 from list
        // Return index 0 card
        public Card DealCard()
        {

        }

        public void IsEmpty()
        {

        }

        public override string ToString()
        {
            string output = "";
            foreach (Card card in cards)
            {
                output += card.ToString() + "\n";
            }
            return output;
        }

    }
}

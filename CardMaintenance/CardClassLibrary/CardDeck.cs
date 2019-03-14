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
            for (int i = 1; i <= 13; i++)
            {
                int value = i;
                for (int j = 1; j <= 4; j++)
                {
                    int suit = j;
                    cards.Add(new Card(i, j));
                }
            }

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

            for (int i = 0; i < cards.Count; i++)
            {
                int randomIndex = generator.Next(1, cards.Count);
                Card temp = cards[i];
                cards[i] = cards[randomIndex];
                cards[randomIndex] = temp;
            }
        }
        // DealCard
        // Get index 0 from list
        // Remove index 0 from list
        // Return index 0 card
        public Card DealCard()
        {
            Card dealtCard = cards[0];

            cards.Remove(dealtCard);
            return dealtCard;
        }

        public bool IsEmpty()
        {
            if (cards.Count == 0)
            {
                return true;
            }
            return false;
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

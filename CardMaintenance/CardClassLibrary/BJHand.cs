using System;
using System.Collections.Generic;
namespace CardClassLibrary
{
    public class BJHand : Hand
    {
        // fields
        int score = 0;
        protected List<Card> bJHandCards;

        // BJHand constructor
        public BJHand()
        {
           bJHandCards = new List<Card>();
        }

        // score property
        public int Score
        {
            get
            {
                foreach (Card cardInBJH in bJHandCards)
                {
                    score += cardInBJH.Value;
                }
                return score;
            }
        }
        // bool methods
        public bool HasAce(int value)
        {
            foreach (Card cardInBJH in handCards)
            {
                if (cardInBJH.Value == 1)
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsBusted(int value1, int value2)
        {
            if (bJHandCards.Score > 21 )
        }
    }
}

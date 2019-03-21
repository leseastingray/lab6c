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
                    if (cardInBJH.IsFaceCard())
                    {
                        score += 10;
                    }
                    else
                    {
                        score += cardInBJH.Value;
                    }
                }
                return score;
            }

        }
        // bool methods
        public bool HasAce()
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
        public bool IsBusted()
        {
            int finalscore = this.Score;
            if (this.HasAce())
            {
                if (this.Score + 10 <= 21)
                {
                    finalscore += 10;
                }
            }
                if (finalscore > 21)
            {
                return true;
            }
            return false;
        }
    }
}

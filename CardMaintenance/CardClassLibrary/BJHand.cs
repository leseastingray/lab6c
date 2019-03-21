using System;
using System.Collections.Generic;
namespace CardClassLibrary
{
    public class BJHand : Hand
    {
        // fields

        // BJHand constructor
        public BJHand()
        {

        }

        // score property
        public int Score
        {
            get
            {
                int score = 0;
                foreach (Card cardInBJH in handCards)
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

using System;

namespace CardClassLibrary
{
    public class Card
    {
        // Card class variables
        private int suit; // suit ranges from 1 to 4
        private int value; // value ranges from 1 to 13

        private string[] suits = { "????", "clubs", "diamonds", "hearts", "spades" };
        private string[] values = { "????", "ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king" };

        // Card class constructors
        // Default constructor
        public Card()
        {
            value = 1;
            suit = 1;
        }

        // Overloaded constructor
        public Card(int v, int s)
        {
            value = v;
            suit = s;
        }

        // Getters and Setters
        public int Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
            }
        }

        public int Suit
        {
            get
            {
                return suit;
            }
            set
            {
                suit = value;
            }
        }

        public override string ToString()
        {
            return values[value] + " of " + suits[suit];
        }

        // CardIsSuit Methods
        public bool IsHeart()
        {
            if (suit == 3)
                return true;
            else
                return false;
        }

        // CardIsFace Methods
        public bool IsFaceCard()
        {
            if (value >= 11 && value <= 13)
                return true;
            else
                return false;
        }

        public bool IsQueen()
        {
            if (value == 12)
                return true;
            else
                return false;
        }

        // CardIsColor Methods
        public bool IsBlack()
        {
            if (suit == 1 || suit == 4)
                return true;
            else
                return false;
        }
    }
}

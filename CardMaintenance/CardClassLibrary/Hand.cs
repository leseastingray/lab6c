using System;
using System.Collections.Generic;
namespace CardClassLibrary
{
    public class Hand
    {
        // field variable
        protected List<Card> handCards;

        // constructor
        public Hand()
        {
            handCards = new List<Card>();
        }
        // count property
        public int NumCards
        {
            get
            {
                return handCards.Count;
            }
        }
        // add method
        public void Add(Card card)
        {
            handCards.Add(card);
        }
        // discard method
        public void Discard(Card card)
        {
            handCards.Remove(card);
        }
        // indexer
        public Card this[int i]
        {
            get
            {
                return handCards[i];
            }
            set
            {
                handCards[i] = value;
            }
        }

        // find specific card by value only
        public Card IndexOf(int value)
        {
            foreach (Card cardInH in handCards)
            {
                if (cardInH.Value == value)
                {
                    return cardInH;
                }
            }
            return null;
        }
        // find specific card by value and suit
        public Card IndexOf(int value, int suit)
        {
            foreach (Card cardInH in handCards)
            {
                if (cardInH.Value == value)
                {
                    if (cardInH.Suit == suit)
                        return cardInH;
                }
                return null;
            }
            return null;
        }

        // bool methods
        public bool HasCard(Card card)
        {
            // go through handCards list
            // check each card
            // if true
            // return true + break
            foreach (Card cardInH in handCards)
            {
                if (cardInH == card)
                {
                    return true;
                }
            }
            return false;
        }
        public bool HasCard(int value)
        {
            foreach (Card cardInH in handCards)
            {
                if (cardInH.Value == value)
                {
                    return true;
                }
            }
            return false;
        }
        public bool HasCard(int value, int suit)
        {
            foreach (Card cardinH in handCards)
            {
                if (cardinH.Value == value && cardinH.Suit == suit)
                {
                    return true;
                }
            }
            return false;
        }
        // ToString method
        public override string ToString()
        {
            string output = "";
            foreach (Card cardInH in handCards)
            {
                output += cardInH.ToString() + "\n";
            }
            return output;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    
    public class Card
    {
        //card properties
        public Suit cardSuit { get; set; }
        public string cardValue { get; set; }

        //enums act as a class within the card class
        public enum Suit { Hearts, Spades, Diamonds, Clubs}

        /// <summary>
        /// Constructor Method
        /// </summary>
        /// <param name="value"></param>
        /// <param name="suit"></param>
        public Card(string value, Suit suit)
        {
            cardSuit = cardSuit;
            cardValue = cardValue;
        }
    }
}

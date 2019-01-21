using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Classes
{
    
    public class Card
    {
        //card properties
        public Suit CardSuit { get; set; }
        public CardValue Value { get; set; }
        public Suit suit { get; set; }

        //card constructor
        public Card(CardValue value, Suit suit)
        {
            Value = value;
            CardSuit = suit;
        }

        public Card()
        {
        }

        //enums act as a class within the card class
        public enum Suit
        {
            Hearts,
            Spades,
            Diamonds,
            Clubs
        }
        public enum CardValue
        {
            Ace,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King
        }
    }
}

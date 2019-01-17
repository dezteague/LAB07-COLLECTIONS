using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    
    public class Card
    {
        //card properties
        public Suit suit { get; set; }
        public CardValue value { get; set; }

        //enums act as a class within the card class
        public enum Suit { Hearts, Spades, Diamonds, Clubs}
        public enum CardValue { one, two, three, four, five, six, seven, eight, nine, ten, jack, queen, king, ace}
    }
}

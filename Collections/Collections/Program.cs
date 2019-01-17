using System;
using System.Collections.Generic;
using Collections;

namespace Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //set up deck of cards
            Card cardOne = new Card();
            cardOne.value = Card.CardValue.ace;
            cardOne.suit = Card.Suit.Clubs;

            Card cardTwo = new Card();
            cardTwo.value = Card.CardValue.king;
            cardTwo.suit = Card.Suit.Diamonds;

            Card cardThree = new Card();
            cardThree.value = Card.CardValue.queen;
            cardThree.suit = Card.Suit.Hearts;

            Card cardFour = new Card();
            cardFour.value = Card.CardValue.jack;
            cardFour.suit = Card.Suit.Spades;

            Card cardFive = new Card();
            cardFive.value = Card.CardValue.ten;
            cardFive.suit = Card.Suit.Diamonds;

            Deck<Card> deck = new Deck<Card>();
            deck.Add(cardOne);
            deck.Add(cardTwo);
            deck.Add(cardThree);
            deck.Add(cardFour);
            deck.Add(cardFive);


        }
    
    }
}

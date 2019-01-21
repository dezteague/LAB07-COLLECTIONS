﻿using System;
using Collections.Classes;

namespace Collections
{
    public class Program
    {
        public static object Deck { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Cards in the Deck:");
            Console.WriteLine("");

            //set up deck of cards
            Deck<Card> Deck = new Deck<Card>();

            Card cardOne = new Card();
            cardOne.value = Card.CardValue.Ace;
            cardOne.suit = Card.Suit.Clubs;

            Card cardTwo = new Card();
            cardTwo.value = Card.CardValue.Two;
            cardTwo.suit = Card.Suit.Diamonds;

            Card cardThree = new Card();
            cardThree.value = Card.CardValue.Three;
            cardThree.suit = Card.Suit.Hearts;

            Card cardFour = new Card();
            cardFour.value = Card.CardValue.Four;
            cardFour.suit = Card.Suit.Spades;

            Card cardFive = new Card();
            cardFive.value = Card.CardValue.Five;
            cardFive.suit = Card.Suit.Diamonds;

            Card cardSix = new Card();
            cardSix.value = Card.CardValue.Six;
            cardSix.suit = Card.Suit.Hearts;

            Card cardSeven = new Card();
            cardSeven.value = Card.CardValue.Seven;
            cardSeven.suit = Card.Suit.Clubs;

            Card cardEight = new Card();
            cardEight.value = Card.CardValue.Eight;
            cardEight.suit = Card.Suit.Diamonds;

            Card cardNine = new Card();
            cardNine.value = Card.CardValue.Nine;
            cardNine.suit = Card.Suit.Spades;

            Card cardTen = new Card();
            cardTen.value = Card.CardValue.Ten;
            cardTen.suit = Card.Suit.Hearts;

            Card cardEleven = new Card();
            cardEleven.value = Card.CardValue.Jack;
            cardEleven.suit = Card.Suit.Spades;

            Card cardTwelve = new Card();
            cardTwelve.value = Card.CardValue.Queen;
            cardTwelve.suit = Card.Suit.Clubs;

            Card cardThirteen = new Card();
            cardThirteen.value = Card.CardValue.King;
            cardThirteen.suit = Card.Suit.Diamonds;

            Deck.Add(cardOne);
            Deck.Add(cardTwo);
            Deck.Add(cardThree);
            Deck.Add(cardFour);
            Deck.Add(cardFive);
            Deck.Add(cardSix);
            Deck.Add(cardSeven);
            Deck.Add(cardEight);
            Deck.Add(cardNine);
            Deck.Add(cardTen);
            Deck.Add(cardEleven);
            Deck.Add(cardTwelve);
            Deck.Add(cardThirteen);

            foreach (Card item in Deck)
            {
                Console.WriteLine($"{item.value}{item.suit}");
            }

            Console.WriteLine("");
            Console.WriteLine("Deal cards:");
            Console.WriteLine("");

            int counter = 0;

            foreach (Card item in Deck)
            {
                counter++;
                if (counter < 7)
                { 
                    Console.WriteLine($"Player 1 cards: {item.value} of {item.suit}");
                }
                else if (counter >= 7 && counter < 13)
                {
                    Console.WriteLine($"Player 2 cards: {item.value} of {item.suit}");
                }
                else
                {
                    Console.WriteLine($"Dealer cards:  {item.value} of {item.suit}");
                }
            }

            Console.WriteLine("Removing Ten of Hearts");

            Card removefromdeck = Deck.Remove(cardTen);
        }
    }
}

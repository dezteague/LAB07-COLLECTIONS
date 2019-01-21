using System;
using System.Collections.Generic;
using Collections;

namespace Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cards in the Deck:");
            Console.WriteLine("");

            //set up deck of cards
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


            Deck<Card> deck = new Deck<Card>();
            deck.Add(cardOne);
            deck.Add(cardTwo);
            deck.Add(cardThree);
            deck.Add(cardFour);
            deck.Add(cardFive);
            deck.Add(cardSix);
            deck.Add(cardSeven);
            deck.Add(cardEight);
            deck.Add(cardNine);
            deck.Add(cardTen);
            deck.Add(cardEleven);
            deck.Add(cardTwelve);
            deck.Add(cardThirteen);

            foreach (Card item in deck)
            {
                Console.WriteLine($"{item.value} {item.suit}");
            }

            Console.WriteLine("");
            Console.WriteLine("Deal cards:");
            Console.WriteLine("");

            int counter = 0;

            foreach (Card item in deck)
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
                    Console.WriteLine($"Dealer cards:  {item.value} of {item.suit}");

            }
        }
    }
}

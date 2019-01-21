using System;
using Xunit;
using Collections.Classes;

namespace CollectionsTest
{
    public class UnitTest1
    {
        [Fact]
        public void AddCardTest()
        {

            Card cardOne = new Card();
            cardOne.Value = Card.CardValue.Jack;
            cardOne.CardSuit = Card.Suit.Spades;

            Deck<Card> Deck = new Deck<Card>();
            Deck.Add(cardOne);

            Assert.Contains(cardOne, Deck);
        }

        [Fact]
        public void GetSetTest()
        {
            Card cardTwo = new Card();
            cardTwo.Value = Card.CardValue.Two;
            cardTwo.CardSuit = Card.Suit.Diamonds;
            var Diamonds = cardTwo.suit;

            Deck<Card> Deck = new Deck<Card>();
            Deck.Add(cardTwo);

            Assert.Equal(Diamonds, cardTwo.suit);
        }

        [Fact]
        public void RemoveCardTest()
        {
            Card cardThree = new Card();
            cardThree.Value = Card.CardValue.Three;
            cardThree.suit = Card.Suit.Hearts;

            Card cardFour = new Card();
            cardFour.Value = Card.CardValue.Four;
            cardFour.suit = Card.Suit.Spades;

            Deck<Card> Deck = new Deck<Card>();
            Deck.Add(cardThree);
            Deck.Add(cardFour);

            Deck.Remove(cardFour);

            Assert.DoesNotContain(cardFour, Deck);
        }
    }
}

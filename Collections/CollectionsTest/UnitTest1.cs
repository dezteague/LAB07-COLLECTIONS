using System;
using Xunit;
using Collections;

namespace CollectionsTest
{
    public class UnitTest1
    {
        [Fact]
        public void CardFiveTest()
        {
            Card cardFive = new Card();
            cardFive.value = Card.CardValue.ten;
            cardFive.suit = Card.Suit.Diamonds;

            Deck<Card> deck = new Deck<Card>();
            deck.Add(cardFive);
        }
    }
}

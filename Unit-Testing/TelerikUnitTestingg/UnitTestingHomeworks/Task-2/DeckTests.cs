﻿namespace Santase.Logic.Tests.Cards
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;
    using System.Linq;
    using Santase.Logic.Cards;

    [TestFixture]
    public class DeckTests
    {
        [Test]
        public void NewDeckShouldContain24Cards()
        {
            Deck testDeck = new Deck();
            Assert.AreEqual(24, testDeck.CardsLeft, "The new deck should contain 24 cards");
        }

        [Test]
        public void TrumpCardShouldBeAValidCard()
        {
            Deck testDeck = new Deck();
            Assert.IsTrue(Enum.IsDefined(typeof(CardSuit), testDeck.TrumpCard.Suit), "Card must have one of the predefined suits");
            Assert.IsTrue(Enum.IsDefined(typeof(CardType), testDeck.TrumpCard.Type), "Card must have one of the predefined types");
        }

        [Test]
        public void GetNextCardShouldReturnAValidCard()
        {
            Deck testDeck = new Deck();
            Assert.IsTrue(Enum.IsDefined(typeof(CardSuit), testDeck.GetNextCard().Suit), "Card must have one of the predefined suits");
            Assert.IsTrue(Enum.IsDefined(typeof(CardType), testDeck.GetNextCard().Type), "Card must have one of the predefined types");
        }

        [Test]
        public void GetNextCardShouldRemoveTheCardFromTheDeck()
        {
            Deck testDeck = new Deck();
            int initialNumberOfCards = testDeck.CardsLeft;
            testDeck.GetNextCard();
            Assert.AreEqual((initialNumberOfCards - 1), testDeck.CardsLeft, "GetNextCard() should remove 1 card from the deck");
        }

        [Test]
        public void ChangeTrumpCardShouldChangeTheTrumpCardIfThereAreCardsLeftInTheDeck()
        {
            Deck testDeck = new Deck();
            Card initialTrumpCard = testDeck.TrumpCard;
            Card newCard = testDeck.GetNextCard();
            testDeck.ChangeTrumpCard(newCard);
            Assert.AreNotSame(initialTrumpCard, testDeck.TrumpCard);
        }

        [TestCase(24)]
        public void ChangeTrumpCardShouldNotChangeTheTrumpCardIfThereAreNoCardsLeftInTheDeck(int cardsToBeDrawn)
        {
            Deck testDeck = new Deck();
            Card initialTrumpCard = testDeck.TrumpCard;
            Card newCard = new Card(CardSuit.Spade, CardType.Ace);
            for (int i = 0; i < cardsToBeDrawn; i++)
            {
                if (i == cardsToBeDrawn - 1)
                {
                    newCard = testDeck.GetNextCard();
                }
                else
                {
                    testDeck.GetNextCard();
                }
            }

            testDeck.ChangeTrumpCard(newCard);

            Assert.AreEqual(0, testDeck.CardsLeft, "There should be no cards left in the deck after drawing 24 cards");
            Assert.AreSame(initialTrumpCard, testDeck.TrumpCard, "ChangeTrumpCard should not change the trump card when there are no cards left in the deck");
        }
    }
}

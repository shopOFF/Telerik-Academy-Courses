namespace Packer.Test
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;

    [TestClass]
    public class HandTest
    {
        public void Hand_ShouldCreateNotNullableObject()
        {
            // Arrange
            List<ICard> cardsInHand = new List<ICard>();
            cardsInHand.Add(new Card(CardFace.Ace, CardSuit.Clubs));
            cardsInHand.Add(new Card(CardFace.Ace, CardSuit.Diamonds));
            cardsInHand.Add(new Card(CardFace.King, CardSuit.Hearts));
            cardsInHand.Add(new Card(CardFace.King, CardSuit.Spades));
            cardsInHand.Add(new Card(CardFace.Seven, CardSuit.Diamonds));
            IHand hand = new Hand(cardsInHand);

            // Act and Assert
            Assert.IsNotNull(hand);

            //// Assert

        }

        [TestMethod]
        public void Hand_ShouldThrowExeption_IfCreatedHandWithEmptyListOfCards()
        {
            // Arrange
            List<ICard> cardsInHand = new List<ICard>();            
            //IHand hand = new Hand(cardsInHand);

            // Act and Assert
            Assert.ThrowsException<ArgumentNullException>(() => new Hand(cardsInHand));

            //// Assert
            
        }

        [TestMethod]
        public void Cards_CardsInHandShouldBeOneAfterAddingOneCard()
        {
            // Arrange
            List<ICard> cardsInHand = new List<ICard>();
            cardsInHand.Add(new Card(CardFace.Ace, CardSuit.Clubs));
            IHand hand = new Hand(cardsInHand);

            // Act
            int cardsInHandCount = hand.Cards.Count;
            int one = 1;

            // Assert
            Assert.AreEqual(one, cardsInHandCount);
        }

        [TestMethod]
        public void Hand_ToStringShouldReturnAllCardsInTheHand()
        {
            // Arrange
            List<ICard> cardsInHand = new List<ICard>();
            cardsInHand.Add(new Card(CardFace.Ace, CardSuit.Clubs));
            cardsInHand.Add(new Card(CardFace.Ace, CardSuit.Diamonds));
            cardsInHand.Add(new Card(CardFace.King, CardSuit.Hearts));
            cardsInHand.Add(new Card(CardFace.King, CardSuit.Spades));
            cardsInHand.Add(new Card(CardFace.Seven, CardSuit.Diamonds));
            IHand hand = new Hand(cardsInHand);

            // Act
            string expectedStringPresentation = "Ace♣ Ace♦ King♥ King♠ Seven♦";

            // Assert
            Assert.AreEqual(expectedStringPresentation, hand.ToString());
        }
    }
}

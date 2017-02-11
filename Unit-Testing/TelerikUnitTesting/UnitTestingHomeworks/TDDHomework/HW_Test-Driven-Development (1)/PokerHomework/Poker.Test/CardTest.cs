namespace Packer.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;

    [TestClass]
    public class CardTest
    {
        [TestMethod]
        public void Card_CreatedCardShouldNotBeNullabe()
        {
            // Arrange
            Card card = new Card(CardFace.Ace, CardSuit.Spades);

            // Act and Assert
            Assert.IsNotNull(card);

            //// Asserts

        }

        [TestMethod]
        public void ToString_ShouldReturnStringValueWithValidCardPresention()
        {
            // Arrange
            Card card = new Card(CardFace.Ace, CardSuit.Spades);

            // Act
            string cardStringPresentation = card.ToString();
            string cardAceSpades = "Ace♠";

            // Assert
            Assert.AreEqual(cardAceSpades.GetType(), cardStringPresentation.GetType());
            Assert.AreEqual(cardAceSpades, cardStringPresentation);
        }

        [TestMethod]
        public void ToString_ShouldAllaysReturnValidCard()
        {
            // Arrange
            Card card = new Card(CardFace.King, CardSuit.Diamonds);

            // Act
            // TODO how to do it

            // Assert
            // TODO how to do it
        }
    }
}

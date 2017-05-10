namespace Packer.Test
{    
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;

    [TestClass]
    public class PokerHandsCheckerTest
    {
        private bool isTrue = true;

		[TestMethod]
		public void PockerHandChecker_ConstructorShouldCreateNotNullableObject()
        {
			// Arrange and Act
            PokerHandsChecker pokerHandChecker = new PokerHandsChecker();

            // Assert
            Assert.IsNotNull(pokerHandChecker);
        }

        [TestMethod]
        public void PockerHandChecker_ShouldThrowArgunmentNullExeptionWhenCreatedWithNull()
        {
            PokerHandsChecker pokerHandChecker = new PokerHandsChecker();
            Assert.ThrowsException<ArgumentNullException>(() => pokerHandChecker.IsValidHand(null));
        }

        [TestMethod]
		public void PockerHandChecker_IsValidWhenContainingExaclyFiveCards()
        {
            // Arrange
            List<ICard> cardsInHand = new List<ICard>();
            cardsInHand.Add(new Card(CardFace.Ace, CardSuit.Clubs));
            cardsInHand.Add(new Card(CardFace.Ace, CardSuit.Diamonds));
            cardsInHand.Add(new Card(CardFace.King, CardSuit.Hearts));
            cardsInHand.Add(new Card(CardFace.King, CardSuit.Spades));
            cardsInHand.Add(new Card(CardFace.Seven, CardSuit.Diamonds));
            IHand hand = new Hand(cardsInHand);

            PokerHandsChecker pokerHandChecker = new PokerHandsChecker();

            // Act
            bool isHandValid = pokerHandChecker.IsValidHand(hand);
            
            // Assert
            Assert.IsTrue(isHandValid);
        }

        [TestMethod]
        public void PockerHandChecker_IsValidWhenContainingDifferentCards()
        {         
            // Arrange
            List<ICard> cardsInHand = new List<ICard>();
            cardsInHand.Add(new Card(CardFace.Ace, CardSuit.Clubs));
            cardsInHand.Add(new Card(CardFace.Ace, CardSuit.Diamonds));
            cardsInHand.Add(new Card(CardFace.King, CardSuit.Hearts));
            cardsInHand.Add(new Card(CardFace.King, CardSuit.Spades));
            cardsInHand.Add(new Card(CardFace.Seven, CardSuit.Diamonds));
            IHand hand = new Hand(cardsInHand);

			PokerHandsChecker pokerHandChecker = new PokerHandsChecker();

            // Act
            bool isHandValid = pokerHandChecker.IsValidHand(hand);

            // Assert
            Assert.IsTrue(isHandValid);
        }

		[TestMethod]
        public void PockerHandChecker_ShouldThrowExeptionWhenCreatingTwoDuplicateCards()
        {
            // Arrange
            List<ICard> cardsInHand = new List<ICard>();
            cardsInHand.Add(new Card(CardFace.Ace, CardSuit.Clubs));
            cardsInHand.Add(new Card(CardFace.Ace, CardSuit.Clubs));
            cardsInHand.Add(new Card(CardFace.King, CardSuit.Hearts));
            cardsInHand.Add(new Card(CardFace.King, CardSuit.Spades));
            cardsInHand.Add(new Card(CardFace.Seven, CardSuit.Diamonds));
            IHand hand = new Hand(cardsInHand);

            PokerHandsChecker pokerHandChecker = new PokerHandsChecker();

            // Act and Assert
            Assert.ThrowsException<InvalidOperationException>(() => pokerHandChecker.IsValidHand(hand));

            //// Assert

        }

        [TestMethod]
        public void PockerHandChecker_ShouldReturnTrueIfHandContainsValidFluch()
        {
            // Arrange
            List<ICard> cardsInHand = new List<ICard>();
            cardsInHand.Add(new Card(CardFace.Ace, CardSuit.Clubs));
            cardsInHand.Add(new Card(CardFace.King, CardSuit.Clubs));
            cardsInHand.Add(new Card(CardFace.Jack, CardSuit.Clubs));
            cardsInHand.Add(new Card(CardFace.Ten, CardSuit.Clubs));
            cardsInHand.Add(new Card(CardFace.Two, CardSuit.Clubs));
            IHand hand = new Hand(cardsInHand);

            PokerHandsChecker pokerHandChecker = new PokerHandsChecker();

			// Act and Assert
            Assert.IsTrue(pokerHandChecker.IsFlush(hand));

			//// Assert
        }

        [TestMethod]
        public void PockerHandChecker_ShouldReturnTrueIfHandContainsValidFourOfKind()
        {
            // Arrange
            List<ICard> cardsInHand = new List<ICard>();
            cardsInHand.Add(new Card(CardFace.King, CardSuit.Clubs));
            cardsInHand.Add(new Card(CardFace.King, CardSuit.Diamonds));
            cardsInHand.Add(new Card(CardFace.King, CardSuit.Hearts));
            cardsInHand.Add(new Card(CardFace.King, CardSuit.Spades));
            cardsInHand.Add(new Card(CardFace.Two, CardSuit.Clubs));
            IHand hand = new Hand(cardsInHand);

            PokerHandsChecker pokerHandChecker = new PokerHandsChecker();

            // Act and Assert
            Assert.IsTrue(pokerHandChecker.IsFourOfAKind(hand));

            //// Assert

        }


        [TestMethod]
        public void PockerHandChecker_ShouldReturnTrueIfHandContainsValidThreeOfKind()
        {
            // Arrange
            List<ICard> cardsInHand = new List<ICard>();
            cardsInHand.Add(new Card(CardFace.King, CardSuit.Clubs));
            cardsInHand.Add(new Card(CardFace.King, CardSuit.Diamonds));
            cardsInHand.Add(new Card(CardFace.King, CardSuit.Hearts));
            cardsInHand.Add(new Card(CardFace.Ace, CardSuit.Spades));
            cardsInHand.Add(new Card(CardFace.Two, CardSuit.Clubs));
            IHand hand = new Hand(cardsInHand);

            PokerHandsChecker pokerHandChecker = new PokerHandsChecker();

            // Act and Assert
            Assert.IsTrue(pokerHandChecker.IsThreeOfAKind(hand));

            //// Assert

        }

        [TestMethod]
        public void PockerHandChecker_ShouldReturnTrue_IfHandContainsValidFullHouse()
        {
            // Arrange
            List<ICard> cardsInHand = new List<ICard>();
            cardsInHand.Add(new Card(CardFace.King, CardSuit.Clubs));
            cardsInHand.Add(new Card(CardFace.King, CardSuit.Diamonds));
            cardsInHand.Add(new Card(CardFace.King, CardSuit.Hearts));
            cardsInHand.Add(new Card(CardFace.Two, CardSuit.Spades));
            cardsInHand.Add(new Card(CardFace.Two, CardSuit.Clubs));
            IHand hand = new Hand(cardsInHand);

            PokerHandsChecker pokerHandChecker = new PokerHandsChecker();

            // Act and Assert
            Assert.IsTrue(pokerHandChecker.IsFullHouse(hand));

            //// Assert

        }

        [TestMethod]
        public void PockerHandChecker_ShouldReturnTrue_IfHandContainsOnePair()
        {
            // Arrange
            List<ICard> cardsInHand = new List<ICard>();
            cardsInHand.Add(new Card(CardFace.King, CardSuit.Clubs));
            cardsInHand.Add(new Card(CardFace.King, CardSuit.Diamonds));
            cardsInHand.Add(new Card(CardFace.Ace, CardSuit.Hearts));
            cardsInHand.Add(new Card(CardFace.Jack, CardSuit.Spades));
            cardsInHand.Add(new Card(CardFace.Two, CardSuit.Clubs));
            IHand hand = new Hand(cardsInHand);

            PokerHandsChecker pokerHandChecker = new PokerHandsChecker();

            // Act and Assert
            Assert.IsTrue(pokerHandChecker.IsOnePair(hand));

            //// Assert

        }

        [TestMethod]
        public void PockerHandChecker_ShouldReturnTrue_IfHandContainsTwoPairs()
        {
            // Arrange
            List<ICard> cardsInHand = new List<ICard>();
            cardsInHand.Add(new Card(CardFace.King, CardSuit.Clubs));
            cardsInHand.Add(new Card(CardFace.King, CardSuit.Diamonds));
            cardsInHand.Add(new Card(CardFace.Ace, CardSuit.Hearts));
            cardsInHand.Add(new Card(CardFace.Jack, CardSuit.Spades));
            cardsInHand.Add(new Card(CardFace.Jack, CardSuit.Clubs));
            IHand hand = new Hand(cardsInHand);

            PokerHandsChecker pokerHandChecker = new PokerHandsChecker();

            // Act and Assert
            Assert.IsTrue(pokerHandChecker.IsTwoPair(hand));

            //// Assert

        }

        [TestMethod]
        public void PockerHandChecker_ShouldReturnTrue_IfHandContainsStraidht()
        {
            // Arrange
            List<ICard> cardsInHand = new List<ICard>();
            cardsInHand.Add(new Card(CardFace.Eight, CardSuit.Clubs));
            cardsInHand.Add(new Card(CardFace.Nine, CardSuit.Diamonds));
            cardsInHand.Add(new Card(CardFace.Ten, CardSuit.Hearts));
            cardsInHand.Add(new Card(CardFace.Jack, CardSuit.Spades));
            cardsInHand.Add(new Card(CardFace.Queen, CardSuit.Clubs));
            IHand hand = new Hand(cardsInHand);

            PokerHandsChecker pokerHandChecker = new PokerHandsChecker();

            // Act and Assert
            Assert.IsTrue(pokerHandChecker.IsStraight(hand));

            //// Assert

        }

        [TestMethod]
        public void PockerHandChecker_ShouldReturnTrue_IfHandContainsStraidhtFlush()
        {
            // Arrange
            List<ICard> cardsInHand = new List<ICard>();
            cardsInHand.Add(new Card(CardFace.Eight, CardSuit.Clubs));
            cardsInHand.Add(new Card(CardFace.Nine, CardSuit.Clubs));
            cardsInHand.Add(new Card(CardFace.Ten, CardSuit.Clubs));
            cardsInHand.Add(new Card(CardFace.Jack, CardSuit.Clubs));
            cardsInHand.Add(new Card(CardFace.Queen, CardSuit.Clubs));
            IHand hand = new Hand(cardsInHand);

            PokerHandsChecker pokerHandChecker = new PokerHandsChecker();

            // Act and Assert
            Assert.IsTrue(pokerHandChecker.IsStraightFlush(hand));

            //// Assert

        }

    }
}

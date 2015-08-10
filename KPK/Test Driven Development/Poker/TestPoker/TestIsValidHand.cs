namespace TestPoker
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;
    using System.Collections;
    using System.Collections.Generic;

    [TestClass]
    public class TestIsValidHand
    {
        // Tests for IsValidHand()
        [TestMethod]
        public void AHandWithFiveDifferentCardsMustBeValid()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace,CardSuit.Hearts),
                new Card(CardFace.Eight,CardSuit.Spades),
                new Card(CardFace.Five,CardSuit.Diamonds),
                new Card(CardFace.King,CardSuit.Clubs),
                new Card(CardFace.Queen,CardSuit.Diamonds)
            });

            bool isValid = checker.IsValidHand(hand);
            Assert.IsTrue(isValid, "Hand with five totaly different cards must be valid.");
        }

        [TestMethod]
        public void AHandWithFiveCardsDifferentFacedAndSameSuitsMustBeValid()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace,CardSuit.Spades),
                new Card(CardFace.Eight,CardSuit.Spades),
                new Card(CardFace.Five,CardSuit.Spades),
                new Card(CardFace.King,CardSuit.Spades),
                new Card(CardFace.Queen,CardSuit.Spades)
            });

            bool isValid = checker.IsValidHand(hand);
            Assert.IsTrue(isValid, "Hand with five card with different faces must be valid.");
        }

        [TestMethod]
        public void AHandWithFiveCardsTwoSameMustBeInvalid()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace,CardSuit.Spades),
                new Card(CardFace.Ace,CardSuit.Spades),
                new Card(CardFace.Five,CardSuit.Spades),
                new Card(CardFace.King,CardSuit.Spades),
                new Card(CardFace.Queen,CardSuit.Spades)
            });

            bool isValid = checker.IsValidHand(hand);
            Assert.IsFalse(isValid, "Hand must be invalid when two cards are the same.");
        }

        [TestMethod]
        public void AHandWithLessThanFiveCardsMustBeInvalid()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace,CardSuit.Hearts),
                new Card(CardFace.Eight,CardSuit.Spades),
                new Card(CardFace.Five,CardSuit.Diamonds),
                new Card(CardFace.King,CardSuit.Clubs)               
            });

            bool isValid = checker.IsValidHand(hand);
            Assert.IsFalse(isValid, "Hand must be have exactly five cards.");
        }

        [TestMethod]
        public void AHandWithMoreThanFiveCardsMustBeInvalid()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace,CardSuit.Hearts),
                new Card(CardFace.Eight,CardSuit.Spades),
                new Card(CardFace.Five,CardSuit.Diamonds),
                new Card(CardFace.King,CardSuit.Clubs),
                new Card(CardFace.Seven,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Clubs),
            });

            bool isValid = checker.IsValidHand(hand);
            Assert.IsFalse(isValid, "Hand must be have exactly five cards.");
        }



    }
}

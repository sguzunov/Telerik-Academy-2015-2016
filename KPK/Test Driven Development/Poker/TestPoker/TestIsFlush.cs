namespace TestPoker
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;
    using System.Collections;
    using System.Collections.Generic;

    [TestClass]
    public class TestIsFlush
    {
        // Tests for IsFlush()
        [TestMethod]
        public void AHandWithSameSuitsAndNonConsecutiveFacesMustBeFlush()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Five,CardSuit.Hearts),
                new Card(CardFace.Queen,CardSuit.Hearts),
                new Card(CardFace.King,CardSuit.Hearts),
                new Card(CardFace.Ace,CardSuit.Hearts),
            });

            bool isValid = checker.IsFlush(hand);
            Assert.IsTrue(isValid, "Hand must be flush having cards with same suits and non consecutive faces.");
        }

        [TestMethod]
        public void AHandWithNotSameSuitsAndNonConsecutiveFacesMustNotBeFlush()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Five,CardSuit.Hearts),
                new Card(CardFace.Jack,CardSuit.Hearts),
                new Card(CardFace.King,CardSuit.Hearts),
                new Card(CardFace.Ace,CardSuit.Diamonds),
            });

            bool isValid = checker.IsFlush(hand);
            Assert.IsFalse(isValid, "Hand must not be flush having cards with different suits and non consecutive faces.");
        }

        [TestMethod]
        public void AHandWithCardsWithConsecutiveFacesAndSameSuitsMustNotBeFlush()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Three,CardSuit.Hearts),
                new Card(CardFace.Four,CardSuit.Hearts),
                new Card(CardFace.Five,CardSuit.Hearts),
                new Card(CardFace.Six,CardSuit.Hearts),
            });

            bool isValid = checker.IsFlush(hand);
            Assert.IsFalse(isValid, "Hand must not be flush having cards with same suits and consecutive faces.");
        }

        [TestMethod]
        public void AHandWithCardsWithConsecutiveFacesAndNotSameSuitsMustNotBeFlush()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Three,CardSuit.Hearts),
                new Card(CardFace.Four,CardSuit.Hearts),
                new Card(CardFace.Five,CardSuit.Spades),
                new Card(CardFace.Six,CardSuit.Hearts),
            });

            bool isValid = checker.IsFlush(hand);
            Assert.IsFalse(isValid, "Hand must not be flush having cards with different suits and consecutive faces.");
        }

        [TestMethod]
        public void AHandWithLessThanFiveCardsCannotBeFlush()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Five,CardSuit.Hearts),
                new Card(CardFace.Jack,CardSuit.Hearts),
                new Card(CardFace.King,CardSuit.Hearts)
            });

            bool isValid = checker.IsFlush(hand);
            Assert.IsFalse(isValid, "To be a flush hand must have exactly five cards.");
        }

        [TestMethod]
        public void AHandWithMoreThanFiveCardsCannotBeFlush()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Five,CardSuit.Hearts),
                new Card(CardFace.Eight,CardSuit.Hearts),
                new Card(CardFace.Ten,CardSuit.Hearts),
                new Card(CardFace.King,CardSuit.Hearts),
                new Card(CardFace.Ace,CardSuit.Hearts)
            });

            bool isValid = checker.IsFlush(hand);
            Assert.IsFalse(isValid, "To be a flush hand must have exactly five cards.");
        }
    }
}

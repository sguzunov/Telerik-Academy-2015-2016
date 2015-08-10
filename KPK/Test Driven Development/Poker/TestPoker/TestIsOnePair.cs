namespace TestPoker
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;
    using System.Collections;
    using System.Collections.Generic;

    [TestClass]
    public class TestIsOnePair
    {
        [TestMethod]
        public void AHandWithTwoOfSameFaceAndThreeNotTheSameFaceNorTheSameAsEachOtherMustBeOnePair()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Four,CardSuit.Spades),
                new Card(CardFace.Five,CardSuit.Hearts),
                new Card(CardFace.Six,CardSuit.Hearts)
            });

            bool isValid = checker.IsOnePair(hand);
            Assert.IsTrue(isValid, "A hand having cards two of the same face " +
            "and other three not the same face nor the same as each other must be one pair.");
        }

        [TestMethod]
        public void AHandWithTwoOfSameFaceAndAnotherTwoNotTheSameFaceButTheSameAsEachOtherMustNotBeOnePair()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Spades),
                new Card(CardFace.Five,CardSuit.Hearts),
                new Card(CardFace.Five,CardSuit.Diamonds)
            });

            bool isValid = checker.IsOnePair(hand);
            Assert.IsFalse(isValid, "A hand having cards two of the same face " +
            "and other two not the same face but the same as each other must not be one pair.");
        }

        [TestMethod]
        public void AHandWithTwoOfSameFaceAndAnotherThreeNotTheSameFaceButTheSameAsEachOtherMustNotBeOnePair()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Spades),
                new Card(CardFace.Ace,CardSuit.Hearts),
                new Card(CardFace.Ace,CardSuit.Diamonds)
            });

            bool isValid = checker.IsOnePair(hand);
            Assert.IsFalse(isValid, "A hand having cards two of the same face " +
            "and other three not the same face but the same as each other must not be one pair.");
        }

        [TestMethod]
        public void AHandWithFiveTotallyDifferentFacedCardsMustNotBeOnePair()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Three,CardSuit.Spades),
                new Card(CardFace.Five,CardSuit.Hearts),
                new Card(CardFace.King,CardSuit.Diamonds)
            });

            bool isValid = checker.IsOnePair(hand);
            Assert.IsFalse(isValid, "A hand having cards totally different cards must not be one pair.");
        }

        [TestMethod]
        public void AHandWithMoreThanFiveCardsMustNotBeOnePair()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Four,CardSuit.Spades),
                new Card(CardFace.Five,CardSuit.Hearts),
                new Card(CardFace.Six,CardSuit.Hearts),
                new Card(CardFace.King,CardSuit.Hearts),
            });

            bool isValid = checker.IsOnePair(hand);
            Assert.IsFalse(isValid, "A hand having more than five cards must not be one pair.");
        }

        [TestMethod]
        public void AHandWithLessThanFiveCardsMustNotBeOnePair()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Two,CardSuit.Spades),
                new Card(CardFace.Five,CardSuit.Hearts)
            });

            bool isValid = checker.IsOnePair(hand);
            Assert.IsFalse(isValid, "A hand having less than five cards must not be one pair.");
        }
    }
}

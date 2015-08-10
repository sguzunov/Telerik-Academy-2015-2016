namespace TestPoker
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;
    using System.Collections;
    using System.Collections.Generic;

    [TestClass]
    public class TestIsTwoPair
    {
        [TestMethod]
        public void AHandWithTwoOfSameFaceAndTwoNotTheSameFaceButTheSameAsEachOtherMustBeTwoPair()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Four,CardSuit.Spades),
                new Card(CardFace.Four,CardSuit.Hearts),
                new Card(CardFace.Six,CardSuit.Hearts)
            });

            bool isValid = checker.IsTwoPair(hand);
            Assert.IsTrue(isValid, "A hand having cards two of the same face " +
            "and other two not the same face but the same as each other must be two pair.");
        }

        [TestMethod]
        public void AHandWithTwoOfSameFaceAndThreeNotTheSameFaceButTheSameAsEachOtherMustNotBeTwoPair()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Four,CardSuit.Spades),
                new Card(CardFace.Four,CardSuit.Hearts),
                new Card(CardFace.Four,CardSuit.Diamonds)
            });

            bool isValid = checker.IsTwoPair(hand);
            Assert.IsFalse(isValid, "A hand having cards two of the same face " +
            "and other three not the same face but the same as each other must not be two pair.");
        }

        [TestMethod]
        public void AHandWithTwoOfSameFaceAndThreeNotTheSameFaceNorTheSameAsEachOtherMustNotBeTwoPair()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Four,CardSuit.Spades),
                new Card(CardFace.Five,CardSuit.Hearts),
                new Card(CardFace.Six,CardSuit.Diamonds)
            });

            bool isValid = checker.IsTwoPair(hand);
            Assert.IsFalse(isValid, "A hand having cards two of the same face " +
            "and other three not the same face nor the same as each other must not be two pair.");
        }

        [TestMethod]
        public void AHandWithFiveTotallyDifferentFacedCardsMustNotBeTwoPair()
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
            Assert.IsFalse(isValid, "A hand having cards totally different cards must not be two pair.");
        }

        [TestMethod]
        public void AHandWithMoreThanFiveCardsMustNotBeTwoPair()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Four,CardSuit.Spades),
                new Card(CardFace.Four,CardSuit.Hearts),
                new Card(CardFace.Six,CardSuit.Hearts),
                new Card(CardFace.Six,CardSuit.Clubs),
            });

            bool isValid = checker.IsOnePair(hand);
            Assert.IsFalse(isValid, "A hand having more than five cards must not be two pair.");
        }

        [TestMethod]
        public void AHandWithLessThanFiveCardsMustNotBeOnePair()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Five,CardSuit.Spades),
                new Card(CardFace.Five,CardSuit.Hearts)
            });

            bool isValid = checker.IsOnePair(hand);
            Assert.IsFalse(isValid, "A hand having less than five cards must not be two pair.");
        }
    }
}

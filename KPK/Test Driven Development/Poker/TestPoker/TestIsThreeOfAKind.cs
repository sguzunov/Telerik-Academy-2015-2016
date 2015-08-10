namespace TestPoker
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;
    using System.Collections;
    using System.Collections.Generic;

    [TestClass]
    public class TestIsThreeOfAKind
    {
        [TestMethod]
        public void AHandWithThreeOfSameFaceAndTwoNotTheSameFaceNorTheSameAsEachOtherMustBeThreeOfAKind()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Two,CardSuit.Spades),
                new Card(CardFace.Five,CardSuit.Hearts),
                new Card(CardFace.Six,CardSuit.Hearts)
            });

            bool isValid = checker.IsThreeOfAKind(hand);
            Assert.IsTrue(isValid, "A hand having cards three of the same face " +
            "and othre two not the same face nor the same as each other must be three of a kind");
        }

        [TestMethod]
        public void AHandWithThreeOfSameFaceAndTwoNotTheSameFaceButTheSameAsEachOtherMustNotBeThreeOfAKind()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Two,CardSuit.Spades),
                new Card(CardFace.Five,CardSuit.Hearts),
                new Card(CardFace.Five,CardSuit.Diamonds)
            });

            bool isValid = checker.IsThreeOfAKind(hand);
            Assert.IsFalse(isValid, "A hand having cards three of the same face " +
            "and othre two not the same face but the same as each other must not be three of a kind");
        }

        [TestMethod]
        public void AHandWithFiveTotallyDifferentFacedCardsMustNotBeThreeOfAKind()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Three,CardSuit.Spades),
                new Card(CardFace.Five,CardSuit.Hearts),
                new Card(CardFace.King,CardSuit.Diamonds)
            });

            bool isValid = checker.IsThreeOfAKind(hand);
            Assert.IsFalse(isValid, "A hand having cards totally different must not be three of a kind.");
        }

        [TestMethod]
        public void AHandWithTwoPairsEachHavingSameFaceMustNotBeThreeOfAKind()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Two,CardSuit.Spades),
                new Card(CardFace.Five,CardSuit.Hearts),
                new Card(CardFace.Five,CardSuit.Diamonds)
            });

            bool isValid = checker.IsThreeOfAKind(hand);
            Assert.IsFalse(isValid, "A hand having two pairs with same face must not be three of a kind,");
        }

        [TestMethod]
        public void AHandWithMoreThanFiveCardsMustNotBeThreeOfAKind()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Two,CardSuit.Spades),
                new Card(CardFace.Five,CardSuit.Hearts),
                new Card(CardFace.Six,CardSuit.Hearts),
                new Card(CardFace.Ten,CardSuit.Hearts)
            });

            bool isValid = checker.IsThreeOfAKind(hand);
            Assert.IsFalse(isValid, "A hand having more than five cards must not be three of a kind.");
        }

        [TestMethod]
        public void AHandWithLessThanFiveCardsMustNotBeThreeOfAKind()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Two,CardSuit.Spades),
                new Card(CardFace.Five,CardSuit.Hearts)
            });

            bool isValid = checker.IsThreeOfAKind(hand);
            Assert.IsFalse(isValid, "A hand having less than five cards must not be three of a kind.");
        }
    }
}

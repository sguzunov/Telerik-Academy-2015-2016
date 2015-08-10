namespace TestPoker
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;
    using System.Collections;
    using System.Collections.Generic;

    [TestClass]
    public class TestIsFourOfAKind
    {
        // Tests for IsFourOfKind()
        [TestMethod]
        public void AHandWithFourSameFacedCardsMustBeFourOfAKing()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Spades),
                new Card(CardFace.King,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Clubs)                
            });

            bool isValid = checker.IsFourOfAKind(hand);
            Assert.IsTrue(isValid, "When a hand has four cards with the same face we have four of a kind.");
        }

        [TestMethod]
        public void AHandHavingFourSameFacedCardsAndSomeWithSameSuitsMustNotBeFourOfAKing()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Clubs),
                new Card(CardFace.Two,CardSuit.Clubs),
                new Card(CardFace.King,CardSuit.Hearts)
            });

            bool isValid = checker.IsFourOfAKind(hand);
            Assert.IsFalse(isValid, "When a hand has four cards with the same face and some are with the same suit we don't have four of a kind.");
        }

        [TestMethod]
        public void AHandHavingDifferentFacedCardsAndDifferentSuitsMustNotBeFourOfAKing()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Five,CardSuit.Hearts),
                new Card(CardFace.Queen,CardSuit.Clubs),
                new Card(CardFace.Ten,CardSuit.Spades),
                new Card(CardFace.King,CardSuit.Hearts)
            });

            bool isValid = checker.IsFourOfAKind(hand);
            Assert.IsFalse(isValid, "When a hand has cards with different face and different suits we don't have four of a kind.");
        }

        [TestMethod]
        public void AHandHavingDifferentFacedCardsAndSameSuitsMustNotBeFourOfAKing()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Five,CardSuit.Diamonds),
                new Card(CardFace.Queen,CardSuit.Diamonds),
                new Card(CardFace.Ten,CardSuit.Diamonds),
                new Card(CardFace.King,CardSuit.Diamonds)
            });

            bool isValid = checker.IsFourOfAKind(hand);
            Assert.IsFalse(isValid, "When a hand has cards with different face and same suits we don't have four of a kind.");
        }

        [TestMethod]
        public void AHandWithLessThanFiveCardsCannotHaveFourOfAKind()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Spades),
                new Card(CardFace.Two,CardSuit.Clubs)
            });

            bool isValid = checker.IsFourOfAKind(hand);
            Assert.IsFalse(isValid, "When a hand has less than five cards we cannot have four of a kind.");
        }

        [TestMethod]
        public void AHandWithMoreThanFiveCardsCannotHaveFourOfAKind()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Ten,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Spades),
                new Card(CardFace.Two,CardSuit.Clubs),
                new Card(CardFace.Six,CardSuit.Spades),
                new Card(CardFace.Two,CardSuit.Spades)
            });

            bool isValid = checker.IsFourOfAKind(hand);
            Assert.IsFalse(isValid, "When a hand has more than five cards we cannot have four of a kind.");
        }
    }
}

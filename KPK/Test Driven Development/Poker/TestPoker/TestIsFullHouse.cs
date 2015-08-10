namespace TestPoker
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;
    using System.Collections;
    using System.Collections.Generic;

    [TestClass]
    public class TestIsFullHouse
    {
        [TestMethod]
        public void AHandWithThreeFromOneFaceAndTwoOfAnotherFaceMustBeFullHouse()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Spades),
                new Card(CardFace.King,CardSuit.Hearts),
                new Card(CardFace.King,CardSuit.Clubs)                
            });

            bool isValid = checker.IsFullHouse(hand);
            Assert.IsTrue(isValid, "A hand having three from one rank and two from another rank cards must be full house");
        }

        [TestMethod]
        public void AHandWithTwoFromOneFaceAndTwoOfAnotherFaceMustBeFullHouse()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Ten,CardSuit.Spades),
                new Card(CardFace.King,CardSuit.Hearts),
                new Card(CardFace.King,CardSuit.Clubs)                
            });

            bool isValid = checker.IsFullHouse(hand);
            Assert.IsFalse(isValid, "A hand having two from one rank and two from another rank cards must not be full house");
        }

        [TestMethod]
        public void AHandWithFiveCardsWithSameFaceMustNotBeFullHouse()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Spades),
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Clubs)                
            });

            bool isValid = checker.IsFullHouse(hand);
            Assert.IsFalse(isValid, "A hand having five cards with same face must not be full house");
        }

        [TestMethod]
        public void AHandWithFiveCardsWithDifferentFaceMustNotBeFullHouse()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Three,CardSuit.Hearts),
                new Card(CardFace.Four,CardSuit.Spades),
                new Card(CardFace.Five,CardSuit.Hearts),
                new Card(CardFace.Six,CardSuit.Clubs)                
            });

            bool isValid = checker.IsFullHouse(hand);
            Assert.IsFalse(isValid, "A hand having five cards with different face must not be full house");
        }

        [TestMethod]
        public void AHandWithMoreThanFiveCardsMustNotBeFullHouse()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Spades),
                new Card(CardFace.King,CardSuit.Hearts),
                new Card(CardFace.King,CardSuit.Clubs),
                new Card(CardFace.Queen,CardSuit.Hearts)
            });

            bool isValid = checker.IsFullHouse(hand);
            Assert.IsFalse(isValid, "A hand having more than five cards must not be full house");
        }

        [TestMethod]
        public void AHandWithLessThanFiveCardsMustNotBeFullHouse()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Spades),
                new Card(CardFace.King,CardSuit.Hearts)
            });

            bool isValid = checker.IsFullHouse(hand);
            Assert.IsFalse(isValid, "A hand having less than five cards must not be full house");
        }
    }
}

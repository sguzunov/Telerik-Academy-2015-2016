namespace TestPoker
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;
    using System.Collections;
    using System.Collections.Generic;


    [TestClass]
    public class TestIsStraight
    {
        [TestMethod]
        public void AHandWithFiveConsecutiveCardsAndDifferentSuitMustBeStraight()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Three,CardSuit.Diamonds),
                new Card(CardFace.Four,CardSuit.Spades),
                new Card(CardFace.Five,CardSuit.Hearts),
                new Card(CardFace.Six,CardSuit.Hearts)                
            });

            bool isValid = checker.IsStraight(hand);

            Assert.IsTrue(isValid, "Consecutive cards with different suit must be straight.");
        }

        [TestMethod]
        public void AHandWithFiveConsecutiveCardsAndSameSuitMustNotBeStraight()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Three,CardSuit.Diamonds),
                new Card(CardFace.Four,CardSuit.Diamonds),
                new Card(CardFace.Five,CardSuit.Diamonds),
                new Card(CardFace.Six,CardSuit.Diamonds)                
            });

            bool isValid = checker.IsStraight(hand);

            Assert.IsFalse(isValid, "Consecutive cards with same suit must not be straight.");
        }

        [TestMethod]
        public void AHandWithFiveNonConsecutiveCardsAndSameSuitMustNotBeStraight()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Three,CardSuit.Diamonds),
                new Card(CardFace.Four,CardSuit.Diamonds),
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Six,CardSuit.Diamonds)                
            });

            bool isValid = checker.IsStraight(hand);

            Assert.IsFalse(isValid, "Non consecutive cards with same suit must not be straight.");
        }

        [TestMethod]
        public void AHandWithFiveNonConsecutiveCardsAndDifferentSuitMustNotBeStraight()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Three,CardSuit.Clubs),
                new Card(CardFace.Four,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Four,CardSuit.Spades)                
            });

            bool isValid = checker.IsStraight(hand);

            Assert.IsFalse(isValid, "Non consecutive cards with different suit must not be straight.");
        }

        [TestMethod]
        public void AHandWithLessThanFiveConsecutiveCardsMustNotBeStraight()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Three,CardSuit.Diamonds),
                new Card(CardFace.Four,CardSuit.Spades),
                new Card(CardFace.Five,CardSuit.Hearts),               
            });

            bool isValid = checker.IsStraight(hand);

            Assert.IsFalse(isValid, "Consecutive cards with less than five cards must not be straight.");
        }

        [TestMethod]
        public void AHandWithMoreThanFiveConsecutiveCardsMustNotBeStraight()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Three,CardSuit.Diamonds),
                new Card(CardFace.Four,CardSuit.Spades),
                new Card(CardFace.Five,CardSuit.Hearts),               
            });

            bool isValid = checker.IsStraight(hand);

            Assert.IsFalse(isValid, "Consecutive cards with more than five cards must not be straight.");
        }
    }
}

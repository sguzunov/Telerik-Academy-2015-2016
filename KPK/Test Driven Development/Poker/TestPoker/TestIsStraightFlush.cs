namespace TestPoker
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;
    using System.Collections;
    using System.Collections.Generic;

    [TestClass]
    public class TestIsStraightFlush
    {
        [TestMethod]
        public void AHandWithFiveConsecutiveCardsWithSameSuitMustBeStraightFlush()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Three,CardSuit.Hearts),
                new Card(CardFace.Four,CardSuit.Hearts),
                new Card(CardFace.Five,CardSuit.Hearts),
                new Card(CardFace.Six,CardSuit.Hearts)
            });

            bool isValid = checker.IsStraightFlush(hand);
            Assert.IsTrue(isValid, "Hand having five consecutive cards with same suit must be straight flush.");
        }

        [TestMethod]
        public void AHandWithFiveNonConsecutiveCardsWithSameSuitMustNotBeStraightFlush()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace,CardSuit.Hearts),
                new Card(CardFace.Three,CardSuit.Hearts),
                new Card(CardFace.Four,CardSuit.Hearts),
                new Card(CardFace.Five,CardSuit.Hearts),
                new Card(CardFace.Six,CardSuit.Hearts)
            });

            bool isValid = checker.IsStraightFlush(hand);
            Assert.IsFalse(isValid, "Hand having five non consecutive cards with same suit must not be straight flush.");
        }

        [TestMethod]
        public void AHandWithFiveConsecutiveCardsWithDifferentSuitMustNotBeStraightFlush()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Three,CardSuit.Hearts),
                new Card(CardFace.Four,CardSuit.Hearts),
                new Card(CardFace.Five,CardSuit.Hearts),
                new Card(CardFace.Six,CardSuit.Diamonds)
            });

            bool isValid = checker.IsStraightFlush(hand);
            Assert.IsFalse(isValid, "Hand having five consecutive cards with different suit must not be straight flush.");
        }

        [TestMethod]
        public void AHandWithLessThanFiveCardsMustNotBeStraightFlush()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Three,CardSuit.Hearts),
                new Card(CardFace.Four,CardSuit.Hearts),
                new Card(CardFace.Five,CardSuit.Hearts)
            });

            bool isValid = checker.IsStraightFlush(hand);
            Assert.IsFalse(isValid, "Hand having less than five consecutive cards with same suit must not be straight flush.");
        }

        [TestMethod]
        public void AHandWithMoreThanFiveCardsMustNotBeStraightFlush()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Three,CardSuit.Hearts),
                new Card(CardFace.Four,CardSuit.Hearts),
                new Card(CardFace.Five,CardSuit.Hearts),
                new Card(CardFace.Six,CardSuit.Hearts),
                new Card(CardFace.Seven,CardSuit.Hearts)
            });

            bool isValid = checker.IsStraightFlush(hand);
            Assert.IsFalse(isValid, "Hand having more than five consecutive cards with same suit must not be straight flush.");
        }
    }
}

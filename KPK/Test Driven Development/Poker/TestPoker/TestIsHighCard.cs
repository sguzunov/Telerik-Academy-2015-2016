namespace TestPoker
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;
    using System.Collections;
    using System.Collections.Generic;

    [TestClass]
    public class TestIsHighCard
    {
        [TestMethod]
        public void AHandWithNonConsecutiveAndWithDifferentSuitCardsMustBeHighCard()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Three,CardSuit.Diamonds),
                new Card(CardFace.King,CardSuit.Spades),
                new Card(CardFace.Five,CardSuit.Hearts),
                new Card(CardFace.Ace,CardSuit.Hearts)
            });

            bool isValid = checker.IsHighCard(hand);
            Assert.IsTrue(isValid, "A hand having non consecutive cards must be high card.");
        }

        [TestMethod]
        public void AHandWithNonConsecutiveAndSameSuitCardsMustNotBeHighCard()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Five,CardSuit.Hearts),
                new Card(CardFace.Queen,CardSuit.Hearts),
                new Card(CardFace.King,CardSuit.Hearts),
                new Card(CardFace.Ace,CardSuit.Hearts),
            });

            bool isValid = checker.IsHighCard(hand);
            Assert.IsFalse(isValid, "A hand having same suited and non consecutive cards must not be high card.");
        }

        [TestMethod]
        public void AHandWithConsecutiveAndSameSuitCardsMustNotBeHighCard()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Three,CardSuit.Hearts),
                new Card(CardFace.Four,CardSuit.Hearts),
                new Card(CardFace.Five,CardSuit.Hearts),
                new Card(CardFace.Six,CardSuit.Hearts),
            });

            bool isValid = checker.IsHighCard(hand);
            Assert.IsFalse(isValid, "A hand having consecutive and same suited cards must not be high card.");
        }

        [TestMethod]
        public void AHandWithConsecutiveAndDifferentSuitCardsMustNotBeHighCard()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Three,CardSuit.Diamonds),
                new Card(CardFace.Four,CardSuit.Clubs),
                new Card(CardFace.Five,CardSuit.Spades),
                new Card(CardFace.Six,CardSuit.Diamonds),
            });

            bool isValid = checker.IsHighCard(hand);
            Assert.IsFalse(isValid, "A hand having consecutive and different suit cards must not be high card.");
        }

        [TestMethod]
        public void AHandHavingFourSameFaceAndDifferentSuitCardsMustNotBeHighCard()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Two,CardSuit.Clubs),
                new Card(CardFace.Two,CardSuit.Spades),
                new Card(CardFace.Ace,CardSuit.Diamonds),
            });

            bool isValid = checker.IsHighCard(hand);
            Assert.IsFalse(isValid, "A hand having four same suit cards with different face must not be high card.");
        }

        [TestMethod]
        public void AHandHavingMoreThanFiveCardsMustNotBeHighCard()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Two,CardSuit.Clubs),
                new Card(CardFace.Two,CardSuit.Spades),
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Hearts)
            });

            bool isValid = checker.IsHighCard(hand);
            Assert.IsFalse(isValid, "A hand having more than five cards must not be high card.");
        }

        [TestMethod]
        public void AHandHavingLessThanFiveCardsMustNotBeHighCard()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Three,CardSuit.Diamonds),
                new Card(CardFace.King,CardSuit.Clubs),
                new Card(CardFace.Ace,CardSuit.Spades)
            });

            bool isValid = checker.IsHighCard(hand);
            Assert.IsFalse(isValid, "A hand having less than five cards must not be high card.");
        }
    }
}

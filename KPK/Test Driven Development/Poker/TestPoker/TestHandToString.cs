namespace TestPoker
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;
    using System.Collections.Generic;

    [TestClass]
    public class TestHandToString
    {
        [TestMethod]
        public void HandToStringShouldReturnValidStringWithOneCard()
        {
            var card = new Card(CardFace.Jack, CardSuit.Hearts);
            var hand = new Hand(new List<ICard>() { card });

            string actualString = hand.ToString();
            Assert.AreEqual("J♥", actualString);
        }

        [TestMethod]
        public void HandToStringShouldReturnValidStringWithMoreThanOneCard()
        {
            var card1 = new Card(CardFace.Jack, CardSuit.Hearts);
            var card2 = new Card(CardFace.Queen, CardSuit.Hearts);
            var card3 = new Card(CardFace.King, CardSuit.Spades);
            var card4 = new Card(CardFace.Ten, CardSuit.Diamonds);
            var card5 = new Card(CardFace.Nine, CardSuit.Spades);
            var hand = new Hand(new List<ICard>() { card1, card2, card3, card4, card5 });

            string actualString = hand.ToString();
            Assert.AreEqual("J♥, Q♥, K♠, 10♦, 9♠", actualString);
        }

        [TestMethod]
        public void HandToStringShouldReturnEmptyStringWhenNoCardsInHand()
        {
            var hand = new Hand(new List<ICard>());

            string actualString = hand.ToString();
            Assert.AreEqual("", actualString);
        }
    }
}

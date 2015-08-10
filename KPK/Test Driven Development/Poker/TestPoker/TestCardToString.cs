namespace TestPoker
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;

    [TestClass]
    public class TestCardToString
    {
        [TestMethod]
        public void CardToStrongShouldReturnStringOfCardRepresentation()
        {
            var card = new Card(CardFace.Ace, CardSuit.Hearts);

            string cardInitial = card.ToString();

            Assert.AreEqual("A♥", cardInitial, "The card string representation should corresponds to it's CardFace and CardSuit.");
        }

        [TestMethod]
        public void TwoSameCardsShouldHaveSameStringRepresentations()
        {
            var card1 = new Card(CardFace.Queen, CardSuit.Clubs);
            var card2 = new Card(CardFace.Queen, CardSuit.Clubs);

            string firstCardInitial = card1.ToString();
            string secondCardInitial = card2.ToString();

            Assert.IsTrue(firstCardInitial == secondCardInitial, "Two same cards should have same string representations.");
        }

        [TestMethod]
        public void TwoSameCardsShouldHaveDifferentStringRepresentations()
        {
            var card1 = new Card(CardFace.Ace, CardSuit.Hearts);
            var card2 = new Card(CardFace.King, CardSuit.Spades);

            string firstCardInitial = card1.ToString();
            string secondCardInitial = card2.ToString();

            Assert.IsTrue(firstCardInitial != secondCardInitial, "Two different cards should have different representations.");
        }
    }
}

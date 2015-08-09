namespace TestDesk
{
    using NUnit.Framework;
    using Santase.Logic;
    using Santase.Logic.Cards;

    [TestFixture]
    public class TestDesk
    {
        private const int INITIAL_DECK_NUMBER_OF_CARDS = 24;

        [Test]
        public void InitialDeckCreationMustHave24Cards()
        {
            var deck = new Deck();

            int numberOfCardsLeft = deck.CardsLeft;

            Assert.AreEqual(INITIAL_DECK_NUMBER_OF_CARDS, numberOfCardsLeft, "New deck must contain 24 cards.");
        }

        [Test]
        public void GettingNextCardFromInitialDeckStateMustLeft23Cards()
        {
            var deck = new Deck();

            var nextCard = deck.GetNextCard();
            int numberOfCardsLeft = deck.CardsLeft;

            Assert.AreEqual(23, numberOfCardsLeft, "After getting one card from initial state, deck must have 23 cards.");
        }

        [Test]
        public void GettingAllNextCardsFromInitialDeckStateMustEmptyTheDeck()
        {
            var deck = new Deck();

            for (int i = 0; i < INITIAL_DECK_NUMBER_OF_CARDS; i++)
            {
                var nextCard = deck.GetNextCard();
            }

            int numberOfLeftCards = deck.CardsLeft;

            Assert.AreEqual(0, numberOfLeftCards, "Getting 24 cards from the deck, left cards must be 23.");
        }

        [TestCase(25)]
        [ExpectedException(typeof(InternalGameException))]
        public void GettingNextCardFromEmptyDeckMustThrowException(int numberOfCardsToRemove)
        {
            var deck = new Deck();

            for (int i = 0; i < numberOfCardsToRemove; i++)
            {
                var nextCard = deck.GetNextCard();
            }
        }

        [Test]
        public void GettingTrumpCardMustReturnValidCard()
        {
            var deck = new Deck();

            var trumpCard = deck.GetTrumpCard;

            Assert.IsInstanceOf(typeof(Card), trumpCard, "Trump card must be instace of Card class.");
        }

        [Test]
        public void TrumpCardMustBeTheSameAsTheNewCard()
        {
            var deck = new Deck();
            var newCard = new Card(CardSuit.Club, CardType.Ten);

            deck.ChangeTrumpCard(newCard);
            var trumpCard = deck.GetTrumpCard;

            Assert.AreSame(trumpCard, newCard, "Changed trump card must be the same as the new card.");
        }
    }
}

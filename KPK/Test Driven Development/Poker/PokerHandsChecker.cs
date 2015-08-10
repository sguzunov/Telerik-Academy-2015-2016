using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        private const int VALUD_NUMBER_OF_CARDS = 5;

        public bool IsValidHand(IHand hand)
        {
            if (hand.Cards.Count != VALUD_NUMBER_OF_CARDS)
            {
                return false;
            }

            var cards = hand.Cards;
            for (int i = 0; i < cards.Count - 1; i++)
            {
                for (int j = i + 1; j < cards.Count; j++)
                {
                    if ((cards[i].Face == cards[j].Face) && (cards[i].Suit == cards[j].Suit))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            var cards = this.SortCardsByFace(hand.Cards);
            int countOfConsecutiveCards = 0;
            countOfConsecutiveCards = this.GetCountOfConsecutiveCards(cards);
            bool areAllCardsTheSameSuit = this.AreAllCardsSameSuit(hand.Cards);



            if (countOfConsecutiveCards != 4 || !areAllCardsTheSameSuit)
            {
                return false;
            }

            return true;
        }

        public bool IsFourOfAKind(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            var cards = this.SortCardsByFace(hand.Cards);

            int countOfRepeatingCards = this.CheckCountOfRepeatingCard(cards);
            int countOfRepeatance = this.CheckCountOfRepeatance(cards);

            if (countOfRepeatingCards != 1 && countOfRepeatance != 4)
            {
                return false;
            }

            return true;
        }

        public bool IsFullHouse(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            var cards = this.SortCardsByFace(hand.Cards);
            int countOfRepeatingCards = this.CheckCountOfRepeatingCard(cards);
            int countOfRepeatance = this.CheckCountOfRepeatance(cards);

            if (countOfRepeatingCards == 2 && countOfRepeatance == 5)
            {
                return true;
            }

            return false;
        }

        public bool IsFlush(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            if (!this.AreAllCardsSameSuit(hand.Cards))
            {
                return false;
            }

            var cards = this.SortCardsByFace(hand.Cards);
            int countOfConsecutiveCards = this.GetCountOfConsecutiveCards(cards);

            if (countOfConsecutiveCards == 4)
            {
                return false;
            }

            return true;
        }

        public bool IsStraight(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            var cards = this.SortCardsByFace(hand.Cards);
            int countOfRepeatingCards = this.GetCountOfConsecutiveCards(cards);
            bool areAllCardsSameSuit = false;

            areAllCardsSameSuit = this.AreAllCardsSameSuit(cards);

            if (countOfRepeatingCards != 4 || areAllCardsSameSuit)
            {
                return false;
            }

            return true;
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            if (!IsValidHand(hand))
            {
                return false;
            }

            var cards = this.SortCardsByFace(hand.Cards);
            int countOfRepeatingCards = this.CheckCountOfRepeatingCard(cards);
            int countOfRepeatance = this.CheckCountOfRepeatance(cards);

            if (countOfRepeatingCards == 1 && countOfRepeatance == 3)
            {
                return true;
            }

            return false;
        }

        public bool IsTwoPair(IHand hand)
        {
            if (!IsValidHand(hand))
            {
                return false;
            }

            var cards = this.SortCardsByFace(hand.Cards);
            int countOfRepeatingCards = this.CheckCountOfRepeatingCard(cards);
            int countOfRepeatance = this.CheckCountOfRepeatance(cards);

            if (countOfRepeatingCards == 2 && countOfRepeatance == 4)
            {
                return true;
            }

            return false;
        }

        public bool IsOnePair(IHand hand)
        {
            if (!IsValidHand(hand))
            {
                return false;
            }

            var cards = this.SortCardsByFace(hand.Cards);
            int countOfRepeatingCards = this.CheckCountOfRepeatingCard(cards);
            int countOfRepeatance = this.CheckCountOfRepeatance(cards);

            if (countOfRepeatingCards == 1 && countOfRepeatance == 2)
            {
                return true;
            }

            return false;
        }

        public bool IsHighCard(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            var cards = this.SortCardsByFace(hand.Cards);
            int countOfConsecutiveCards = this.GetCountOfConsecutiveCards(cards);
            int countOfRepeatingCards = this.CheckCountOfRepeatingCard(cards);
            bool areAllCardsSameSuit = this.AreAllCardsSameSuit(cards);

            if (countOfRepeatingCards == 0 && countOfConsecutiveCards != 4 && !areAllCardsSameSuit)
            {
                return true;
            }

            return false;
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }

        // Check if all cards are the same suit
        private bool AreAllCardsSameSuit(IList<ICard> cards)
        {
            var firstCardSuit = cards[0].Suit;
            for (int i = 1; i < cards.Count; i++)
            {
                if (firstCardSuit != cards[i].Suit)
                {
                    return false;
                }
            }

            return true;
        }

        //
        private int GetCountOfConsecutiveCards(IList<ICard> cards)
        {
            int countOfConsecutiveCards = 0;
            for (int i = 1; i < cards.Count; i++)
            {
                if ((int)cards[i].Face - (int)cards[i - 1].Face == 1)
                {
                    countOfConsecutiveCards++;
                }
            }

            return countOfConsecutiveCards;
        }

        // Gets the count of duplicate cards.
        private int CheckCountOfRepeatingCard(IList<ICard> cards)
        {
            var repeatingCards = new HashSet<int>();

            for (int i = 0; i < cards.Count - 1; i++)
            {
                for (int j = i + 1; j < cards.Count; j++)
                {
                    if (cards[i].Face == cards[j].Face)
                    {
                        repeatingCards.Add((int)cards[i].Face);
                    }
                }
            }

            int countOfRepeatigCards = 0;
            countOfRepeatigCards = repeatingCards.Count;

            return countOfRepeatigCards;
        }

        // Gets the count of repeatance only of duplicate cards.
        private int CheckCountOfRepeatance(IList<ICard> cards)
        {
            var dict = new Dictionary<int, int>();

            foreach (var value in cards)
            {
                if (dict.ContainsKey((int)value.Face))
                    dict[(int)value.Face]++;
                else
                    dict[(int)value.Face] = 1;
            }

            int count = 0;
            foreach (var card in dict)
            {
                if (card.Value != 1)
                {
                    count += card.Value;
                }
            }

            return count;
        }

        private IList<ICard> SortCardsByFace(IList<ICard> cards)
        {
            for (int i = 0; i < cards.Count - 1; i++)
            {
                for (int j = i + 1; j < cards.Count; j++)
                {
                    if ((int)cards[i].Face > (int)cards[j].Face)
                    {
                        var oldValue = cards[i];
                        cards[i] = cards[j];
                        cards[j] = oldValue;
                    }
                }
            }

            return cards;
        }
    }
}

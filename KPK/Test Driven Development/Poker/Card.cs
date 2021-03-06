﻿using System;

namespace Poker
{
    public class Card : ICard
    {
        public CardFace Face { get; private set; }
        public CardSuit Suit { get; private set; }

        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public override string ToString()
        {
            string cardSuit = CardExtensions.ToFriendlyCardSuit(this.Suit);
            string cardFace = CardExtensions.ToFriendlyCardFace(this.Face);
            string cardInitial = cardFace + cardSuit;

            return cardInitial;
        }
    }
}

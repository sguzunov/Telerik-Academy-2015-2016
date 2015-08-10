﻿namespace Poker
{
    using System;

    public static class CardExtensions
    {
        public static string ToFriendlyCardSuit(this CardSuit suit)
        {
            switch (suit)
            {
                case CardSuit.Clubs:
                    return "♣";
                case CardSuit.Diamonds:
                    return "♦";
                case CardSuit.Hearts:
                    return "♥";
                case CardSuit.Spades:
                    return "♠";
                default:
                    throw new ArgumentException("Invalid card suit.");
            }
        }

        public static string ToFriendlyCardFace(this CardFace face)
        {
            switch (face)
            {
                case CardFace.Two:
                    return "2";
                case CardFace.Three:
                    return "3";
                case CardFace.Four:
                    return "4";
                case CardFace.Five:
                    return "5";
                case CardFace.Six:
                    return "6";
                case CardFace.Seven:
                    return "7";
                case CardFace.Eight:
                    return "8";
                case CardFace.Nine:
                    return "9";
                case CardFace.Ten:
                    return "10";
                case CardFace.Jack:
                    return "J";
                case CardFace.Queen:
                    return "Q";
                case CardFace.King:
                    return "K";
                case CardFace.Ace:
                    return "A";
                default:
                    throw new ArgumentException("Invalid card face");
            }
        }
    }
}

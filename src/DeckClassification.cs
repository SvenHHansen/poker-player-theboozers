using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nancy.Simple
{
    public static class DeckClassification
    {
        public static bool IsRoyalFlush(IList<Card> deck)
        {
            return false;
        }

        public static bool IsStraightFlush(IList<Card> deck)
        {
            return false;
        }

        public static bool IsFourOfAKind(IList<Card> deck)
        {
            return false;
        }

        public static bool IsFullHouse(IList<Card> deck)
        {
            return false;
        }

        public static bool IsFlush(IList<Card> deck)
        {
            return false;
        }

        public static bool IsStraight(IList<Card> deck)
        {
            return false;
        }

        public static bool IsThreeOfAKind(IList<Card> deck)
        {
            return false;
        }

        public static bool IsTwoPair(IList<Card> deck)
        {
            return false;
        }

        public static bool IsOnePair(IList<Card> deck)
        {
            return false;
        }

        public static bool IsHighestCard(IList<Card> deck)
        {
            return true;
        }

        public static HandEnum GetHand(IList<Card> deck)
        {
            var hand = HandEnum.HighCard;

            if(IsRoyalFlush(deck))
            {
                hand = HandEnum.RoyalFlush;
            }
            else if (IsStraightFlush(deck))
                {
                hand = HandEnum.StraightFlush;
}
            else if(IsFourOfAKind(deck))
                {
             hand = HandEnum.FourOfAKind;}
            else if(IsFullHouse(deck))
                {
            hand = HandEnum.FullHouse;}
                        else if(IsFlush(deck))
                {
            hand = HandEnum.Flush;}
                                    else if(IsStraight(deck))
                {
            hand = HandEnum.Straight;}
            else if(IsThreeOfAKind(deck))
                {
            hand = HandEnum.ThreeOfAKind;}
                        else if(IsTwoPair(deck))
                {
            hand = HandEnum.TwoPairs;}
            else if(IsOnePair(deck))
                {
            hand = HandEnum.OnePair;}
               else if(IsHighestCard(deck))
                {
            hand = HandEnum.HighCard;}

            return hand;
        }

    }
}

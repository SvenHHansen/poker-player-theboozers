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
			bool isRoyalFlush = deck.Min(card => card.Rank) == RankEnum.N10 && IsStraightFlush(deck);
			return false;
        }

        public static bool IsStraightFlush(IList<Card> deck)
        {
            var isStraightFlush = false;

         var possibleStraightFlush =    deck.GroupBy(card => card.Suit).FirstOrDefault(group => group.Count() >= 5);

            if(possibleStraightFlush != null)
            {
                isStraightFlush = IsStraight(deck.Where(x=>x.Suit == possibleStraightFlush.Key).ToList());
            }

            return isStraightFlush;
        }

        public static bool IsFourOfAKind(IList<Card> deck)
        {
			return deck.GroupBy(card => card.Rank).Any(group => group.Count() == 4);
        }

        public static bool IsFullHouse(IList<Card> deck)
        {
			return IsOnePair(deck) && IsThreeOfAKind(deck);
        }

        public static bool IsFlush(IList<Card> deck)
        {
			return deck.GroupBy(card => card.Suit).Any(group => group.Count() >= 5);
        }

        public static bool IsStraight(IList<Card> deck)
        {
            var sortedCards = deck.OrderBy(x => x.Rank).ToList();
            var straight = false;

            while (sortedCards.Count() >= 5)
            {
                straight = CheckStraight(sortedCards);

                if(straight)
                {
                    break;
                }
                else
                {
                    sortedCards.RemoveAt(0);
                }
            
            }

            return straight;
        }

        private static bool CheckStraight(IList<Card> sortedCards)
        {
            var straight = true;

            for (int i = 0; i < 5; i++)
            {
                if(GetEnumValue(sortedCards[i].Rank) != GetEnumValue(sortedCards[i+1].Rank)+1)
                {
                    straight = false;
                    break;
                }
            }

            return straight;
        }

        private static int GetEnumValue(RankEnum rank)
        {
            return (int)rank;
        }

        public static bool IsThreeOfAKind(IList<Card> deck)
        {
			return deck.GroupBy(card => card.Rank).Any(group => group.Count() >= 3);
        }

        public static bool IsTwoPair(IList<Card> deck)
        {
            int foundPairs = 0;

            if(deck.Count()>=4)
            {
                var deckPairs = deck.GroupBy(d => d.Suit);

                foreach (var deckPair in deckPairs)
                {
                    if(deckPair.Count()>=2)
                    {
                        foundPairs++;
                    }
                }
            }

            return foundPairs>=2;
        }

        public static bool IsOnePair(IList<Card> deck)
        {
            return deck.GroupBy(c => c.Rank).Any(l => l.Count() == 2);
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

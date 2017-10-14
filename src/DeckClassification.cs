using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nancy.Simple
{
    public class DeckClassification
    {
        public bool IsRoyalFlush(IList<Card> deck)
        {
            return false;
        }

        public bool IsStraightFlush(IList<Card> deck)
        {
            return false;
        }

        public bool IsFourOfAKind(IList<Card> deck)
        {
            return false;
        }

        public bool IsFullHouse(IList<Card> deck)
        {
            return false;
        }

        public bool IsFlush(IList<Card> deck)
        {
            return false;
        }

        public bool IsStraight(IList<Card> deck)
        {
            var possibleStraights = new List<List<Card>>()
            {
                new List<Card> { new Card() { rank = "6" }, new Card() { rank = "7" }, new Card() { rank = "8" }, new Card() { rank = "9" }, new Card() { rank = "10" }},
                new List<Card> { new Card() { rank = "7" }, new Card() { rank = "8" }, new Card() { rank = "9" }, new Card() { rank = "10" }, new Card() { rank = "J" }, },
                new List<Card> { new Card() { rank = "8" }, new Card() { rank = "9" }, new Card() { rank = "10" }, new Card() { rank = "J" }, new Card() { rank = "Q" }, },
                new List<Card> { new Card() { rank = "9" }, new Card() { rank = "10" }, new Card() { rank = "J" }, new Card() { rank = "Q" }, new Card() { rank = "K" }, },
                new List<Card> { new Card() { rank = "10" }, new Card() { rank = "J" }, new Card() { rank = "Q" }, new Card() { rank = "K" }, new Card() { rank = "A" }},
            };
            if (deck.Count < 5)
            {
                return false;
            }

            if (deck.Count == 5)
            {
                foreach (var possibleStraight in possibleStraights)
                {
                    if (deck.SequenceEqual(possibleStraight))
                    {
                        return true;    // found straight!
                    }
                }
            }

            if (deck.Count == 6)
            {
                return IsStraight(deck.Skip(0).Take(5).ToArray())
                    || IsStraight(deck.Skip(1).Take(5).ToArray());
            }

            if (deck.Count == 7)
            {
                return IsStraight(deck.Skip(0).Take(5).ToArray())
                    || IsStraight(deck.Skip(1).Take(5).ToArray())
                    || IsStraight(deck.Skip(2).Take(5).ToArray());
            }

            return false;
        }

        public bool IsThreeOfAKind(IList<Card> deck)
        {
			return deck.GroupBy(card => card.rank).Any(group => group.Count() == 3);
        }

        public bool IsTwoPair(IList<Card> deck)
        {
            int foundPairs = 0;

            if(deck.Count()>=4)
            {
                var deckPairs = deck.GroupBy(d => d.suit);

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

        public bool IsOnePair(IList<Card> deck)
        {
            return deck.GroupBy(c => c.rank).Any(l => l.Count() == 2);
        }

        public bool IsHighestCard(IList<Card> deck)
        {
            return true;
        }

        public HandEnum GetHand(IList<Card> deck)
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

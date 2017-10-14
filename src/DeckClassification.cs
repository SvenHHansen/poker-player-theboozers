using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nancy.Simple
{
    public class DeckStub
    {

    }

    public class DeckClassification
    {
        public bool IsRoyalFlush(DeckStub deck)
        {

            return false;
        }

        public bool IsStraightFlush(DeckStub deck)
        {
            return false;
        }

        public bool IsFourOfAKind(DeckStub deck)
        {
            return false;
        }

        public bool IsFullHouse(DeckStub deck)
        {
            return false;
        }

        public bool IsFlush(DeckStub deck)
        {
            return false;
        }

        public bool IsStraight(DeckStub deck)
        {
            return false;
        }

        public bool IsThreeOfAKind(DeckStub deck)
        {
            return false;
        }

        public bool IsTwoPair(DeckStub deck)
        {
            return false;
        }

        public bool IsOnePair(DeckStub deck)
        {
            return false;
        }

        public bool IsHighestCard(DeckStub deck)
        {
            return true;
        }

    }
}

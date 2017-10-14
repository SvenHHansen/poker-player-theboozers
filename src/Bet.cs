using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Nancy.Simple
{

    public static class Bet
    {
        public static int CalculateBet(HandEnum hand, int cash)
        {
            switch(hand)
            {
                case HandEnum.RoyalFlush:
                case HandEnum.StraightFlush:
                case HandEnum.FourOfAKind:
                case HandEnum.FullHouse:
                case HandEnum.Flush:
                case HandEnum.Straight:
                    return cash;
                case HandEnum.ThreeOfAKind:
                case HandEnum.TwoPairs:
                    return cash/2;
                case HandEnum.OnePair:
                    return cash/4;
         
                default:
                    return cash / 20;
            }
            
        }
    }
}
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
                    return cash;
                default:
                    return cash / 20;
            }
            
        }
    }
}
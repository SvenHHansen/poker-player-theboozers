namespace Nancy.Simple
{
    public static class HandProbabilities
    {
        public static double ProbabilityForHand(HandEnum hand)
        {
            switch(hand)
            {
                case HandEnum.OnePair:
                    return 0.43832255;
                case HandEnum.TwoPairs:
                    return 0.23495536;
                case HandEnum.ThreeOfAKind:
                    return 0.04829870;
                case HandEnum.Straight:
                    return 0.04619382;
                case HandEnum.Flush:
                    return 0.03025494;
                case HandEnum.FullHouse:
                    return 0.02596102;
                case HandEnum.FourOfAKind:
                    return 0.00168067;
                case HandEnum.StraightFlush:
                    return 0.00027851;
                case HandEnum.RoyalFlush:
                    return 0.00003232;
                default:
                    return 0.17411920;  // Propability for "high card" as default
            }
        }
    }
}

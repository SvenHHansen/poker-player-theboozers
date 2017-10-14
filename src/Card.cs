using System;
using System.Collections.Generic;

namespace Nancy.Simple
{
    	public class Card
	{
        [Obsolete]
        public Card()
        {

        }

        public Card(CommunityCard communityCard)
        {
            rank = communityCard.rank;
            suit = communityCard.suit;
            Rank = GetRankEnum(rank);
            Suit = GetSuitEnum(suit);
        }

        public Card(HoleCard holdCard)
        {
            rank = holdCard.rank;
            suit = holdCard.suit;
            Rank = GetRankEnum(rank);
            Suit = GetSuitEnum(suit);     
        }

        public RankEnum GetRankEnum(string rank)
        {
            switch(rank)
            {
                case "clubs": return RankEnum.clubs;
                case "diamonds": return RankEnum.diamonds;
                case "hearts": return RankEnum.hearts;
                case "spades": return RankEnum.spades;                    
            }

            return default(RankEnum);
        }

        public SuitEnum GetSuitEnum(string suit)
        {
            switch (suit)
            {
                case "2": return SuitEnum.N2;
                case "3": return SuitEnum.N3;
                case "4": return SuitEnum.N4;
                case "5": return SuitEnum.N5;
                case "6": return SuitEnum.N6;
                case "7": return SuitEnum.N7;
                case "8": return SuitEnum.N8;
                case "9": return SuitEnum.N9;
                case "10": return SuitEnum.N10;
                case "J": return SuitEnum.J;
                case "Q": return SuitEnum.Q;
                case "A": return SuitEnum.A;
                case "K": return SuitEnum.K;
            }

            return default(SuitEnum);
        }

        [Obsolete]
        public string rank { get; set; }
        [Obsolete]
        public string suit { get; set; }

        public RankEnum Rank { get; set; }
		public SuitEnum Suit { get; set; }
    }
}

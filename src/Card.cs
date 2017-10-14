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

        public SuitEnum GetSuitEnum(string rank)
        {
            switch(rank)
            {
                case "clubs": return SuitEnum.Clubs;
                case "diamonds": return SuitEnum.Diamonds;
                case "hearts": return SuitEnum.Hearts;
                case "spades": return SuitEnum.Spades;                    
            }

            return default(SuitEnum);
        }

        public RankEnum GetRankEnum(string suit)
        {
            switch (suit)
            {
                case "2": return RankEnum.N2;
                case "3": return RankEnum.N3;
                case "4": return RankEnum.N4;
                case "5": return RankEnum.N5;
                case "6": return RankEnum.N6;
                case "7": return RankEnum.N7;
                case "8": return RankEnum.N8;
                case "9": return RankEnum.N9;
                case "10": return RankEnum.N10;
                case "J": return RankEnum.J;
                case "Q": return RankEnum.Q;
                case "A": return RankEnum.A;
                case "K": return RankEnum.K;
            }

            return default(RankEnum);
        }

        [Obsolete]
        public string rank { get; set; }
        [Obsolete]
        public string suit { get; set; }

        public RankEnum Rank { get; set; }
		public SuitEnum Suit { get; set; }
    }
}

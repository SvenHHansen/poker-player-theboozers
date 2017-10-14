using System;
using System.Collections.Generic;

namespace Nancy.Simple
{

	public class CommunityCard
	{
		public string rank { get; set; }
		public string suit { get; set; }

        public Card ConvertToCard()
        {
            var card = new Card();
            card.rank = rank;
            card.suit = suit;
            return card;
        }
	}
}

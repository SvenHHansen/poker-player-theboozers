using System;
using System.Collections.Generic;

namespace Nancy.Simple
{
    	public class Card
	{
        public string rank { get; set; }
        public string suit { get; set; }

        public RankEnum Rank { get; set; }
		public SuitEnum Suit { get; set; }
    }
}

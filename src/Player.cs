using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace Nancy.Simple
{

	public class Player
	{
		public int id { get; set; }
		public string name { get; set; }
		public string status { get; set; }
		public string version { get; set; }
		public int stack { get; set; }
		public int bet { get; set; }
		public List<HoleCard> hole_cards { get; set; }

        public static Player GetCurrentPlayer(IList<Player> playerList)
        {
               return playerList.Where(x=>x.hole_cards.Count>0).First();
        }
	}
}

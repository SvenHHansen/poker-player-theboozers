using Newtonsoft.Json.Linq;
using System.Linq;
using System.Collections.Generic;

namespace Nancy.Simple
{
	public static class PokerPlayer
	{
		public static readonly string VERSION = "Default C# folding player";

		public static int BetRequest(JObject gameState)
		{
			GameState gameStateSerialized = ReadData.GameState(gameState);
            var currentPlayer = Player.GetCurrentPlayer(gameStateSerialized.players);

            var hand = DeckClassification.GetHand(GetActualCards(gameStateSerialized));

            if(GetActualCards(gameStateSerialized).Count() < 6)
            {
                return gameStateSerialized.players.Select(x=>x.bet).Max();
            }
            else
            {
                return Bet.CalculateBet(hand, currentPlayer.stack);
            }
		}

		public static void ShowDown(JObject gameState)
		{
			//TODO: Use this method to showdown
		}

        public static List<Card> GetActualCards(GameState gameState)
        {
            var currentPlayer = Player.GetCurrentPlayer(gameState.players);
            List<Card> cardList = gameState.community_cards.Select(x=>new Card(x)).ToList();
            cardList.AddRange(currentPlayer.hole_cards.Select(x=>new Card(x)));
            return new List<Card>();
        }
	}
}


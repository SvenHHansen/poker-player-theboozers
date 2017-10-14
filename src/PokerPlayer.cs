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
            
            return Bet.CalculateBet(hand, currentPlayer.stack);
		}

		public static void ShowDown(JObject gameState)
		{
			//TODO: Use this method to showdown
		}

        public static List<Card> GetActualCards(GameState gameState)
        {
            var currentPlayer = Player.GetCurrentPlayer(gameState.players);
            List<CommunityCard> cardList = gameState.community_cards;
            cardList.AddRange(currentPlayer.hole_cards);
            return new List<Card>();
        }
	}
}


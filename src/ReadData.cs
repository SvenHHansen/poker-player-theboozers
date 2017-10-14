using Newtonsoft.Json.Linq;

namespace Nancy.Simple
{
	public static class ReadData
	{
		public static GameState GameState(JObject data)
		{
			GameState gameState = data.ToObject<GameState>();

			return gameState;
		}
	}
}

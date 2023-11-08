using System.Collections.Generic;
using System.Linq;

namespace _5letters.Services
{
    public class GameDataToStart
    {
        public string Token;
        public string VictoryWord;
        public string PlayerName;
        
        public GameDataToStart()
        {
            //получение данных из бд
        }
    }
    
    public class GameStatistics
    {
        public string PlayerToken;
        public string PlayerName;
        public List<string> Worlds;
        public string VictoryWord;
        public GameStages Result;

        public GameStatistics(string playerToken, string playerName, List<string> worlds, string victoryWord, GameStages result)
        {
            PlayerToken = playerToken;
            PlayerName = playerName;
            VictoryWord = victoryWord;
            Worlds = worlds;
            VictoryWord = victoryWord;
            Result = result;

        }
        
        public static void ReturnGameStatistics(Game nowGame)
        {
            //записывает статистику в бд;
            var stats = new GameStatistics(nowGame.PlayerToken,nowGame.PlayerName,
                nowGame.WordsInGame.Select(word=>word.StringWord).ToList(),
                nowGame.VictoryWord, nowGame.GameStage);
        }
    }
}
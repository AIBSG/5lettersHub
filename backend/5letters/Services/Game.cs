using System;
using System.Collections.Generic;
using System.Linq;

public class Game
{
	public string VictoryWord;
	public List<Word> WordsInGame;
	public string PlayerName;
	public GameStages GameStage;
	public Game(string playerName, string victoryWord)
	{
		PlayerName = playerName;
		VictoryWord = victoryWord;
		WordsInGame = new List<Word>();
		GameStage = GameStages.GameInProgress;

	}

	public static Game RunGame(Game nowGame, string nowWorld)
	{
		nowGame.WordsInGame.Add(Word.ChekWord(nowGame.VictoryWord, nowWorld));
		if (nowGame.WordsInGame.Last().Status == WordStatus.VictoryWord)
			nowGame.GameStage = GameStages.Victory;
		else if (nowGame.WordsInGame.Count == 5)
			nowGame.GameStage = GameStages.Defeat;
		return nowGame;
	}
	
	public static Game GameCreator(string victoryWord, string playerToken) 
	{
		return new Game(playerToken, victoryWord);
	}
}

public enum GameStages
{
	GameInProgress,
	Victory,
	Defeat
}

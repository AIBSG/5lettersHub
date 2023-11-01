using System;
using System.Collections.Generic;
using System.Linq;

public class Word
{
	public List<Letter> Letters;
	public WordStatus Status;
	public Word()
	{
		Letters = new List<Letter>();
	}
//здесь еще длжен быть метод который проверяет существует ли слово, но я не знаю как его рализовать. Будет ближе к концу проекта 
	public static Word ChekWord(string victoryWord, string nowWord)
	{
		Word result = new Word();
		for (int i = 0; i < 5; i++)
		{
			var nowLetter = nowWord[i];
			if (victoryWord[i] == nowLetter)
			{
				result.Letters.Add(new Letter(nowLetter, PositionInVictoryWord.RightPlace));
			}
			else if (victoryWord.Contains(nowLetter))
			{
				result.Letters.Add(new Letter(nowLetter, PositionInVictoryWord.InWord));
			}
			else
			{
				result.Letters.Add(new Letter(nowLetter, PositionInVictoryWord.WrongLetter));
			}
		}

		if (result.Letters.All(x => x.Position == PositionInVictoryWord.RightPlace))
		{
			result.Status = WordStatus.VictoryWord;
		}
		else
		{
			result.Status = WordStatus.NotVictoryWord;		
		}

		return result;
	}
}

public enum WordStatus
{
	VictoryWord,
	NotVictoryWord,
	ErrorWord
}

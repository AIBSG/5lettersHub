using System;

public class Letter
{
	public char WordLetter;
	public PositionInVictoryWord Position;
	public Letter(char letter, PositionInVictoryWord positionInVictoryWord)
	{
		WordLetter = letter;
		Position = positionInVictoryWord;
	}
}

public enum PositionInVictoryWord
{
	RightPlace,
	InWord,
	WrongLetter
}

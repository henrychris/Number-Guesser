using System;

public class Number_Guesser
{
	public Number_Guesser()
	{
	}

	public int Answer_Generator(int min, int max)
    {
		Random rnd = new Random();
		int answer = rnd.Next(min, max);

		return answer;
    }

}

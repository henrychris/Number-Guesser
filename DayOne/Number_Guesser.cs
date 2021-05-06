using System;

public class Number_Guesser
{
	public Number_Guesser(int min, int max)
	{
		Answer_Generator(min, max);
	}

	public int Answer_Generator(int min, int max)
    {
		Random rnd = new Random();
		int answer = rnd.Next(min, max);

		return answer;
    }

	public void 


}

using System;

namespace DayOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int minValue = 0, maxValue = 0, guess, answer = 0;
            int numberOfGuesses = 5;
            int count = 0;
            String input = "z";

            while (input.ToUpper() != "Q")
            {


                // Collect user input
                bool valid1 = false;
                while (!valid1)
                {
                    try
                    {
                        Console.WriteLine("What range will you like to guess from? ");
                        Console.Write("Minimum value: ");
                        minValue = int.Parse(Console.ReadLine());

                        Console.Write("Maximum value: ");
                        maxValue = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Number_Guesser ng = new Number_Guesser();
                        answer = ng.Answer_Generator(minValue, maxValue);

                        valid1 = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("You have to input a number.");
                        Console.WriteLine();
                    }
                }

                while (count < numberOfGuesses)
                {
                    Console.Write($"Guess #{count + 1}: ");
                    guess = int.Parse(Console.ReadLine());

                    if (guess < answer)
                    {
                        Console.WriteLine("Your guess was less than the answer.");
                    }
                    else if (guess > answer)
                    {
                        Console.WriteLine("Your guess was higher than the answer.");
                    }
                    else
                    {
                        Console.WriteLine("Correct!");
                        break;
                    }
                    if (count == numberOfGuesses)
                    {
                        Console.WriteLine("Sorry! You have run out of guesses.");
                    }
                    count++;
                   
                }
                Console.WriteLine("Input Q to exit, or any other key to restart.");
                input = Console.ReadLine();
            }
            
        }
    }
}
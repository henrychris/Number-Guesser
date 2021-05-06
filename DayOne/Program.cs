using System;

namespace DayOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int minValue, maxValue;
            int numberOfGuesses = 5;
            
            // Collect user input
            Console.WriteLine("What range will you like to guess from? ");
            Console.Write("Minimum value: ");
            minValue = int.Parse(Console.ReadLine());

            Console.Write("\nMaximum value: ");
            maxValue = int.Parse(Console.ReadLine());

            Number_Guesser ng = new Number_Guesser(minValue, maxValue + 1);
        }
    }
}
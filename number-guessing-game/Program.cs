using System;
using System.Collections.Generic;

namespace numberguessinggame
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            Random rand = new Random();
            answer = rand.Next(10) + 1;
            while (!IsGuessCorrect())
            {
                GetGuess();
                GiveHint();
            }
        }

		private static void GiveHint()
        {
            string message;
            if (guess > answer) 
            {
                message = "You guessed too high.";
            } 
            else if (guess < answer) 
            {
                message = "You guessed too low.";
            }
            else 
            {
                message = "You got it! Well done.";
            }
            Console.WriteLine(message);
        }

        private static int guess = 0;
		private static int answer;
		
		private static void GetGuess()
		{
			string sGuess = "";
			Console.WriteLine("Guess a number from 1 to 10:");
			sGuess = Console.ReadLine();
			while (!Int32.TryParse(sGuess, out guess))
			{
				Console.WriteLine("Please enter a valid guess...");
			}
		}

        private static bool IsGuessCorrect()
        {
            return guess == answer;
        }
    }
}

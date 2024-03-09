using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordToGuess = "giraffe";
            string userGuess = "";
            int attemptCount = 0;
            int maxAttempts = 3;
            bool isOutOfAttempts = false;

            Console.WriteLine("Welcome to the Guessing Game!");
            Console.WriteLine("You have 3 attempts to guess the word.");

            while (userGuess != wordToGuess && !isOutOfAttempts) 
            {
                if (attemptCount < maxAttempts)
                {
                    Console.Write("Enter guess: ");
                    userGuess = Console.ReadLine();
                    attemptCount++;
                } 
                else
                {
                    isOutOfAttempts = true;
                }
            }
            if (isOutOfAttempts)
            {
                Console.Write("You lose, you used up all your tries");
            } else
            {
                Console.Write("You Win!");
            }
                
          Console.ReadLine();
        }
    }
}

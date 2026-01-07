using System;
using System.Data;
using System.Globalization;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string response;
        do
        {
            Random randomNumber = new Random();
            int magicNumber = randomNumber.Next(1, 101);
            int guess = -1;
            int guessCount = 0;
            
            while (magicNumber != guess)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                    guessCount++;
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                    guessCount++;
                }
                else
                {
                    guessCount++;
                    Console.WriteLine($"You guessed it! It took you {guessCount} guesses.");
                }
            }

            Console.WriteLine("Do you want to play again? (yes or no)");
            response = Console.ReadLine();

        } while (response == "yes");

        }
}
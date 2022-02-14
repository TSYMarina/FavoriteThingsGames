using System;

namespace FavoriteThingsGames
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! You again? Want to play, huh? Alright. Guess my favorite number between 1 and 100 then. Take a guess!");

            var r = new Random();
            var favNumber = r.Next(1, 100);
            var userInput = int.Parse(Console.ReadLine());

            
            {
                if (userInput == favNumber)
                {
                    Console.WriteLine("WOW! Congratulations! This is correct");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine("Too high!");
                }
                else
                {
                    Console.WriteLine("Too low!");
                }
            }

        }
    }
}

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

            bool isDone = false;

            while(!isDone)
            { 
            var userInputNum = int.Parse(Console.ReadLine());


                {
                    if (userInputNum == favNumber)
                    {
                        Console.WriteLine("WOW! Congratulations! This is correct.");
                        isDone = true;
                    }
                    else if (userInputNum > favNumber)
                    {
                        Console.WriteLine("Too high! Try again?");

                    }
                    else
                    {
                        Console.WriteLine("Too low! Try again :)");
                    }
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueGame = true;
            List<int> scoreList = new List<int>();
            int scoreSum = 0;
            Console.WriteLine("Welcome to Piglet!");
            do
            {
                Random rnd = new Random();
                int dice = rnd.Next(1, 7);
                Console.WriteLine($"You rolled a {dice}");

                if (dice != 1)
                {
                    scoreList.Add(dice);
                    Console.WriteLine("Roll again?");
                    string rollAgain = Console.ReadLine();

                    if (rollAgain == "y")
                    {
                        continueGame = false;
                    }
                    else if(rollAgain == "n")
                    {
                        foreach (var score in scoreList)
                        {
                            scoreSum += score;
                        }
                        Console.WriteLine($"You got {scoreSum} points.");
                        continueGame = true;
                    }
                }
                else
                {
                    Console.WriteLine($"You got {scoreSum} points.");
                    continueGame = true;
                }

            } while (!continueGame);
        }
    }
}

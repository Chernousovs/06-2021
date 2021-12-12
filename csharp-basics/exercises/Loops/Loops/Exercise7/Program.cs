using System;
using System.Collections.Generic;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueGame = true;
            bool isNotOptionSelected = true;
            List<int> scoreList = new List<int>();
            int scoreSum = 0;
            Console.WriteLine("Welcome to Piglet!");
            do
            {
                Random rnd = new Random();
                int dice = rnd.Next(1, 7);
                Console.WriteLine($"You rolled a {dice}");
                isNotOptionSelected = true;

                if (dice != 1)
                {
                    scoreList.Add(dice);
                    Console.WriteLine("Roll again?");
                    
                    while (isNotOptionSelected)
                    {
                        string rollAgain = Console.ReadLine();
                        if (rollAgain == "y")
                        {
                            continueGame = true;
                            isNotOptionSelected = false;
                        }
                        else if (rollAgain == "n")
                        {
                            foreach (var score in scoreList)
                            {
                                scoreSum += score;
                            }
                            Console.WriteLine($"You got {scoreSum} points.");
                            continueGame = false;
                            isNotOptionSelected = false;
                        }
                        else
                        {
                            Console.WriteLine("To continue press - y \n" +
                                "To quit press - n");
                        }
                    }                   
                }
                else
                {
                    Console.WriteLine($"You got {scoreSum} points.");
                    continueGame = false;
                }

            } while (continueGame);
        }
    }
}

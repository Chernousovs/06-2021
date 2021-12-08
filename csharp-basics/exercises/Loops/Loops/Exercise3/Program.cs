using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter MIN number: ");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter MAX number: ");
            int max = int.Parse(Console.ReadLine());
            int[] arrayOfRandom = new int[20];
            Random randNum = new Random();

            for (var i = 0; i < arrayOfRandom.Length; i++)
            {
                arrayOfRandom[i] = randNum.Next(min, max);
            }

            Console.WriteLine(string.Join(", ", arrayOfRandom));
            Console.WriteLine("Enter number which index you want to know:");

            int num = int.Parse(Console.ReadLine());
            List<int> listOfIndexes = new List<int>();

            for (var numIndex = 0; numIndex < arrayOfRandom.Length; numIndex++)
            {
                if (!arrayOfRandom.Contains(num))
                {
                    Console.WriteLine($"There is no number {num}");
                    break;
                }

                if (num == arrayOfRandom[numIndex])
                {
                    listOfIndexes.Add(numIndex);
                }
            }

            string success =
                $"In array of numbers, {(listOfIndexes.Count == 1 ? "index" : "indexes")} of {num} = {string.Join(", ", listOfIndexes)}";
            Console.WriteLine($"{(listOfIndexes.Count > 0 ? success : "")}");
        }
    }
}

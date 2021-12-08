using System;
using System.Collections.Generic;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first word:");
            string word1 = Console.ReadLine();
            Console.WriteLine("Enter first word:");
            string word2 = Console.ReadLine();
            string dot = ".";
            List<string> listOfDots = new List<string>();

            for (int i = 0; i < 50; i++)
            {
                listOfDots.Add(dot);
            }

            Console.WriteLine($"{word1}{string.Join("", listOfDots)}{word2}");
        }
    }
}

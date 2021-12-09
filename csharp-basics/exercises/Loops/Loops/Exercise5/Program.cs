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

            int lengthStringOfDots = 30 - (word1.Length + word2.Length);

            for (int i = 0; i < lengthStringOfDots; i++)
            {
                listOfDots.Add(dot);
            }

            Console.WriteLine($"{word1}{string.Join("", listOfDots)}{word2}");
        }
    }
}

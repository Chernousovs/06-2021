using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("min? ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("max? ");
            int max = int.Parse(Console.ReadLine());
            List<int> listOfNumbers = new List<int>();

            for (var i = min; i <= max; i++)
            {
                listOfNumbers.Add(i);
            }

            Console.WriteLine(string.Join("", listOfNumbers));
            int firstNumber;

            for (int i = 1; i < max; i++)
            {
                firstNumber= listOfNumbers.First();
                for (var index = 1; index < max; index++)
                {
                    listOfNumbers[index - 1] = listOfNumbers[index];
                }

                listOfNumbers[^1] = firstNumber;
                Console.WriteLine(string.Join("", listOfNumbers));
            }
        }
    }
}

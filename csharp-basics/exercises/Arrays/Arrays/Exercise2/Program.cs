using System;
using System.Collections.Generic;

namespace Exercise2
{
    class Program
    {       
        // TODO: Write a C# program to sum values of an array.
        // Array values are starting from min (including) till max (including) number. 
        private static void Main(string[] args)
        {
            var sum = 0;

            Console.WriteLine("Please enter a min number");
            int minNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a max number");
            int maxNumber = int.Parse(Console.ReadLine());

            List<int> newList = new List<int>();

            for (var i = minNumber; i <= maxNumber ; i++)
            {
                newList.Add(i);
            }

            int[] arr = newList.ToArray();

            for (var i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine("The sum is " + sum);
            Console.ReadKey();
        }
    }
}

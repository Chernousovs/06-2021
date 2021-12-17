using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name count in list :   ");
            int nameCount = int.Parse(Console.ReadLine());
            List<string> listOfNames = new List<string>();

            for (int i = 0; i < nameCount; i++)
            {
                Console.Write("Enter name: ");
                listOfNames.Add(Console.ReadLine());
            }

            Console.WriteLine($"Unique name list contains: {string.Join(", ", listOfNames.ToHashSet())}");
        }
    }
}

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
            HashSet<string> listOfNames = new HashSet<string>();
            bool exit = false;

            do
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    exit = true;
                }
                else
                {
                    listOfNames.Add(name);
                }
            } while (!exit);

            Console.WriteLine($"Unique name list contains: {string.Join(", ", listOfNames)}");
        }
    }
}

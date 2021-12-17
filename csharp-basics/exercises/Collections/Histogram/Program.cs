﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        

        private static void Main(string[] args)
        {
            List<int> listOfInts = new List<int>();
            string a = string.Join(" ", File.ReadAllLines(@"C:\Users\vtche\source\06-2021\csharp-basics\exercises\Collections\Histogram\midtermscores.txt").ToList());

            var intsList = a.Split(' ');

            foreach (var num in intsList)
            {
                listOfInts.Add(int.Parse(num));
            }

            var groupNames = new[] { "00 - 09", "10-19", "20-29", "30-39", "40-49", "50-59", "60-69", "70-79", "80-89", "90-99", "100" };

            var sortedByGroups = listOfInts.GroupBy(v => groupNames[v / 10], p => p).ToDictionary(group => group.Key, group => group.ToList());

            int n = 0;

            //foreach (var v in sortedByGroups.OrderBy(i => i.Key))
            //{
            //    n = 0;
            //    Console.Write($"{v.Key} : ");
            //    foreach (var k in v)
            //    {
            //        n++;
            //    }

            //    Console.WriteLine("  " + new string('*', n));
            //}

            List<int> scoreList = new List<int>();

            foreach (var t in groupNames)
            {
                Console.Write($"{t} : ");
                if (sortedByGroups.TryGetValue(t, out scoreList))
                {
                    Console.Write("  " + new string('*', scoreList.Count()));
                }
                
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

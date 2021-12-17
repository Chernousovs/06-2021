using System;
using System.Collections.Generic;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> hashSet = new HashSet<string>{"a", "b", "c"};
            hashSet.Add("d");
            hashSet.Add("e");
            Console.WriteLine(string.Join(", ", hashSet));
            hashSet.Clear();
            hashSet.Add("a");
            hashSet.Add("a");

            Console.WriteLine(string.Join(", ", hashSet));
            Console.ReadKey();
        }
    }
}

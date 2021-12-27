using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\vtche\source\06-2021\csharp-basics\exercises\Collections\WordCount\lear.txt");

            Console.WriteLine($"Lines = {text.Split('\n').Count()}\n" +
                              $"Words = {text.Split('\n', ' ').Count()}\n" +
                              $"Chars = {text.ToCharArray().Count()}");
            Console.ReadKey();
        }
    }
}

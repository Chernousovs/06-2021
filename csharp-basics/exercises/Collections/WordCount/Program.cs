using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    public class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"..\..\..\WordCount\lear.txt");

            Console.WriteLine(LineCounter(text));
            Console.WriteLine(WordsCounter(text));
            Console.WriteLine(CharsCounter(text));
            Console.ReadKey();
        }

        public static string LineCounter(string text)
        {
            return $"Lines = {text.Split('\n').Count()}";
        }

        public static string WordsCounter(string text)
        {
            return $"Words = {text.Split('\n', ' ').Count()}";
        }

        public static string CharsCounter(string text)
        {
            return $"Chars = {text.ToCharArray().Count()}";
        }
    }
}

using System;

namespace Exercise4
{
    class Program
    {
        //TODO: print all vowels using for and foreach
        static void Main(string[] args)
        {
            char[] vowels = {'a', 'e', 'i', 'o', 'u'};

            /*
            todo - use for
            */

            for (var i = 0; i < vowels.Length; i++)
            {
                Console.WriteLine(vowels[i]);
            }

            /*
            todo - use foreach
            */

            foreach (var vowel in vowels)
            {
                Console.WriteLine(vowel);
            }
        }
    }
}

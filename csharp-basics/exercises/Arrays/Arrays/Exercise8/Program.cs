using System;
using System.Text;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = {"codelex", "leviathan", "hello", "world"};
            var rnd = new Random();
            var word = words[rnd.Next(0, words.Length)];
            var guessable = new string('_', word.Length);
            var misses = string.Empty;
            bool isGameFinished = false;

            while (!isGameFinished)
            {
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-");
                Console.WriteLine($"word: {guessable}");
                Console.WriteLine();
                Console.WriteLine($"Misses: {misses}");
                Console.WriteLine();
                Console.Write("Guess: ");
                var input = Console.ReadKey();
                var guess = input.KeyChar;
                Console.WriteLine();
                Console.WriteLine();

                if (WordContains(word, guess))
                {
                    for (var i = 0; i < word.Length; i++)
                    {
                        if (word.ToLower()[i] == char.ToLower(guess))
                        {
                            var sb = new StringBuilder(guessable);
                            sb[i] = word[i];
                            guessable = sb.ToString();
                        }
                    }
                }
                else
                {
                    misses += guess;
                }

                if (word == guessable)
                {
                    isGameFinished = true;
                    Console.WriteLine("-=-=-=-=-=-=-=-=-=-");
                    Console.WriteLine($"word: {guessable}");
                    Console.WriteLine();
                    Console.WriteLine($"Misses: {misses}");
                    Console.WriteLine();
                    Console.WriteLine("YOU GOT IT!");
                }
                else if (misses.Length > word.Length)
                {
                    isGameFinished = true;
                    Console.WriteLine("-=-=-=-=-=-=-=-=-=-");
                    Console.WriteLine($"word: {guessable}");
                    Console.WriteLine();
                    Console.WriteLine($"Misses: {misses}");
                    Console.WriteLine();
                    Console.WriteLine("TOO MUCH MISSES - YOU LOSE!");
                }

                if (isGameFinished)
                {
                    Console.Write("Play again? y/n  ");
                    var playAgain = Console.ReadKey().KeyChar == 'y';
                    if (playAgain)
                    {
                        isGameFinished = false;
                        word = words[rnd.Next(0, words.Length)];
                        guessable = new string('_', word.Length);
                        misses = string.Empty;
                    }
                }
            }

            Console.WriteLine("\nGoodbye!");
        }

        public static bool WordContains(string word, char guess)
        {
            return word.ToLower().IndexOf(char.ToLower(guess)) > -1;
        }
    }
}

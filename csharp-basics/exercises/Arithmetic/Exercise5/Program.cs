using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 100);

            Console.WriteLine("I'm thinking of a number between 1-100.  Try to guess it.");

            int guess = Convert.ToInt32(Console.ReadLine());

            if (guess == num)
            {
                Console.WriteLine("You guessed it!  What are the odds?!?");
            }
            else if (guess < num)
            {
                Console.WriteLine($"Sorry, you are too low.  I was thinking of {num}");
            }
            else
            {
                Console.WriteLine($"Sorry, you are too high.  I was thinking of {num}");
            }
        }
    }
}

using System;

namespace Exercise6
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PLease enter maximum count of numbers:");
            int maxLength = int.Parse(Console.ReadLine());

            for (var index = 1; index <= maxLength; index++)
            {
                if (index % 3 == 0)
                {
                    Console.Write("Fizz ");
                }
                else if (index % 5 == 0)
                {
                    Console.Write("Buzz ");
                }
                else if (index % 3 == 0 && index % 5 == 0)
                {
                    Console.Write("FizzBuzz ");
                }
                else
                {
                    Console.Write(index + " ");
                }

                if (index % 20 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}

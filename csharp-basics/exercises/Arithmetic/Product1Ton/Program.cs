using System;

namespace Product1Ton
{
    class Program
    {
        static void Main(string[] args)
        {
            var productOfIntegers = 1;
            const int lowerBound = 1;
            const int upperBound = 10;

            for (var index = lowerBound; index <= upperBound; index++)
            {
                productOfIntegers *= index;
            }

            Console.WriteLine(productOfIntegers);
        }
    }
}

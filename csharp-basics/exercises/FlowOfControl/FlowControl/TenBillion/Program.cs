using System;

namespace TenBillion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer number less than ten billion: ");

            var input = Console.ReadLine();
            long number;
            
            if (long.TryParse(input, out number)) 
            {
                if (number < 0) 
                {
                    number *= -1;
                }

                if (number >= 10000000000) 
                {
                    Console.WriteLine("Number is greater or equals 10,000,000,000!");
                } 
                else 
                {
                    int digits = 1;
                    if (number < 100) 
                    {
                        digits = 2;
                    } 
                    else if (number < 1000) 
                    {
                        digits = 3;
                    } 
                    else if (number < 10000) 
                    {
                        digits = 4;
                    } 
                    else if (number < 100000) 
                    {
                        digits = 5;
                    } 
                    else if (number < 1000000) 
                    {
                        digits = 6;
                    } 
                    else if (number < 10000000) 
                    {
                        digits = 7;
                    } 
                    else if (number < 100000000) 
                    {
                        digits = 8;
                    } 
                    else if (number < 1000000000) 
                    {
                        digits = 9;
                    } 
                    else if (number < 10000000000) 
                    {
                        digits = 10;
                    }

                    Console.WriteLine("Number of digits in the number: " + digits);
                }
            } 
            else 
            {
                Console.WriteLine("The number is not a long");
            }

            Console.ReadKey();
        }
    }
}

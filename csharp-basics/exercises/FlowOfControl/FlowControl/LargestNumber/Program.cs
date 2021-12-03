using System;

namespace LargestNumber
{
    class Program
    {
        //TODO: Write a C# program to to find the largest of three numbers.
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number: ");
            var input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the 2nd number: ");
            var input2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the 3rd number: ");
            var input3 = Convert.ToInt32(Console.ReadLine());
        
            /*
            todo - expected output:
            Input the 1st number: 25
            Input the 2nd number: 78
            Input the 3rd number: 87
             */
            if (input1 > input2 && input1 > input3)
            {
                Console.WriteLine($"1st number -{input1}- is largest");
            }
            else if (input2 > input1 && input2 > input3)
            {
                Console.WriteLine($"2st number -{input2}- is largest");
            }
            else
            {
                Console.WriteLine($"3st number -{input3}- is largest");
            }

            Console.ReadKey();
        }
    }
}

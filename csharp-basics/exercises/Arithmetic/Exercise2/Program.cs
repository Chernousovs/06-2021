using System;

namespace CheckOddEven 
{
    class Program
    {
        static void Main(string[] args)
        {
            int enteredNumber = Convert.ToInt32(Console.ReadLine());

            if (0 == enteredNumber % 2)
            {
                Console.WriteLine($"{enteredNumber} is Even Number");
            }
            else
            {
                Console.WriteLine($"{enteredNumber} is Odd Number");
            }
            Console.WriteLine("Bye!");
        }
    }
}

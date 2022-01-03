using System;

namespace CheckOddEven 
{
    public class Program
    {
        static void Main(string[] args)
        {
            int enteredNumber = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(CheckOddOrEven(enteredNumber));
            Console.WriteLine("Bye!");
        }

        public static string CheckOddOrEven(int enteredNumber)
        {
            if (0 == enteredNumber % 2)
            {
                return $"{enteredNumber} is Even Number";
            }
            else
            {
                return $"{enteredNumber} is Odd Number";
            }
        }
    }
}

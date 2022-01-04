using System;

namespace Exercise1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(CheckFor15(firstNumber, secondNumber));
        }

        public static bool CheckFor15(int firstNumber, int secondNumber)
        {
            return (firstNumber == 15 || secondNumber == 15
                                      || firstNumber + secondNumber == 15
                                      || firstNumber - secondNumber == 15
                                      || secondNumber - firstNumber == 15);
        }
    }
}

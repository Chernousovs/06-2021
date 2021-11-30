using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool res = false;
            Console.WriteLine("Enter first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            if (firstNumber == 15 || secondNumber == 15 
                                  || firstNumber + secondNumber == 15 
                                  || firstNumber - secondNumber == 15 
                                  || secondNumber - firstNumber == 15)
            {
                res = true;
            }


            Console.WriteLine(res);
        }
    }
}

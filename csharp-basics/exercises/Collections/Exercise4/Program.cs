using System;
using System.Linq;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number to check is it HAPPY or not: ");
            
            string number = Console.ReadLine();
            int startNumber = Convert.ToInt32(number);

            Console.WriteLine(IsHappy(startNumber) ? "This number is HAPPY" : "This number NOT HAPPY");

            Console.ReadKey();
        }

        private static bool IsHappy(int startNumber)
        {
            int[] arr = startNumber.ToString().Select(n => Convert.ToInt32(n.ToString())).ToArray();
            int sum = 0;
            bool exit = false;
            do
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += (int) Math.Pow(arr[i], 2);
                }

                if (sum == 1 || sum == startNumber)
                {
                    exit = true;
                }
                else
                {
                    arr = sum.ToString().Select(n => Convert.ToInt32(n.ToString())).ToArray();

                    sum = 0;
                }

            } while (!exit);

            return sum == 1;
        }
    }
}

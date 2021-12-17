using System;
using System.Linq;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number to check is it HAPPY or not: ");
            int sum = 0;
            string number = Console.ReadLine();
            int startNumber = Convert.ToInt32(number);
            int[] arr = number.ToCharArray().Select(n => Convert.ToInt32(n.ToString())).ToArray();
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
                    arr = sum.ToString().ToCharArray().Select(n => Convert.ToInt32(n.ToString())).ToArray();
                    sum = 0;
                }

            } while (!exit);

            if (sum == 1)
            {
                Console.WriteLine("This number is HAPPY");
            }
            else
            {
                Console.WriteLine("This number NOT HAPPY");
            }

            Console.ReadKey();
        }
    }
}

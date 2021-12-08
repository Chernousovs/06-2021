using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            
            Console.WriteLine("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            /*
            todo - complete loop to multiply i with itself n times, it is NOT allowed to use Math.Pow()
            */
            int res;

            for (i = 0; i <= n; i++)
            {
                res = i * i;
                Console.WriteLine(res);
            }

            Console.ReadKey();
        }
    }
}

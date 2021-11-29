using System;

namespace CozaLozaWoza
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var index = 1; index <= 110; index++)
            {
                if (index % 3 == 0)
                {
                    Console.Write("Coza");
                }
                else if (index % 5 == 0)
                {
                    Console.Write("Woza");
                }
                else if (index % 3 == 0 && index % 5 == 0)
                {
                    Console.Write("CozaWoza");
                }
                else
                {
                    Console.Write(index);
                }
            }
        }
    }
}

using System;

namespace Exercise8
{
    class AsciiFigure
    {
        static void Main(string[] args)
        {
            const int n = 3;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('/', 4*4 - 4*i)
                                  + new string('*', 8*i)
                                  + new string('\\', 4*4 - 4*i));
            }
        }
    }
}

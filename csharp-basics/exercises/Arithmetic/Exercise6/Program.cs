using System;

namespace CozaLozaWoza
{
    public class Program
    {
        static void Main(string[] args)
        {
            int index = 0;

            for (index = 1; index <= 110; index++)
            {
               Console.WriteLine(CheckNumber(index));
            }
        }

        public static string CheckNumber(int index)
        {
            if (index % 3 == 0 && index % 5 == 0) 
            {
                return "CozaWoza";
            }
            else if (index % 5 == 0)
            {
                return "Woza";
            }
            else if (index % 3 == 0)
            {
                return "Coza";
            }
            else
            {
                return index.ToString();
            }
        } 
    }
}

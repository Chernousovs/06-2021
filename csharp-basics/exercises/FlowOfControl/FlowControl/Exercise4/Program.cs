using System;
using System.Runtime.CompilerServices;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            var x = Console.ReadLine();

            if (int.TryParse(x, out number))
            {
                switch (number) 
                {
                    case 0:
                        Console.WriteLine("Monday");
                        break;
                    case 1:
                        Console.WriteLine("Tuesday");
                        break;
                    case 2:
                        Console.WriteLine("Wednesday");
                        break;
                    case 3:
                        Console.WriteLine("Thursday");
                        break;
                    case 4:
                        Console.WriteLine("Friday");
                        break;
                    case 5:
                        Console.WriteLine("Saturday");
                        break;
                    case 6:
                        Console.WriteLine("Sunday");
                        break;
                    default:
                        Console.WriteLine("Not a valid day");
                        break;
                }
            }
            else
            {
                Console.WriteLine("It is not a number");
            }
        }
    }
}

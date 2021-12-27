using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Points p1 = new Points(5, 2);
            Points p2 = new Points(-3, 6);

            Points.SwapPoints(ref p1, ref p2);

            Console.WriteLine("(" + p1.X + ", " + p1.Y + ")");
            Console.WriteLine("(" + p2.X + ", " + p2.Y + ")");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    public class Points
    {
        public Points(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; }

        public int Y { get; }

        public static void SwapPoints(ref Points p1, ref Points p2)
        {
            var temp = new Points(p1.X, p1.Y);

            p1 = p2;
            p2 = temp;
        }
    }
}

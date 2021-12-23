using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public class Vegetable : Food
    {
        public Vegetable(int foodQuantity) : base(foodQuantity)
        {
        }

        public override string ToString()
        {
            return $"Vegetable {Quantity()}";
        }
    }
}

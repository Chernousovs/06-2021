using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public abstract class Food
    {
        public int _foodQuantity;

        public Food()
        {

        }

        public Food(int foodQuantity)
        {
            _foodQuantity = foodQuantity;
        }

        public void SetFoodQuantity(int foodQuantity)
        {
            _foodQuantity = foodQuantity;
        }

        public int Quantity()
        {
            return _foodQuantity;
        }

        public abstract string ToString();
    }
}

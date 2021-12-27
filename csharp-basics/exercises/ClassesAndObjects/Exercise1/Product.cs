using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Product
    {
        private string _name;
        private double _price;
        private int _amount;
        public Product(string name, double priceAtStart, int amountAtStart)
        {
            _name = name;
            _price = priceAtStart;
            _amount = amountAtStart;
        }

        public void PrintProduct()
        {
            Console.WriteLine($"{_name}, price {_price}, amount {_amount}");
        }

        public void ChangePrice(double newPrice)
        {
            _price = newPrice;
        }

        public void ChangeQuantity(int newAmount)
        {
            _amount = newAmount;
        }
    }
}

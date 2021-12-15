using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Product
    {
        public Product(string name, double priceAtStart, int amountAtStart)
        {
            Name = name;
            Price = priceAtStart;
            Amount = amountAtStart;
        }

        private string Name { get; }
        private double Price { get; set; }
        private int Amount { get; set; }

        public void PrintProduct()
        {
            Console.WriteLine($"{Name}, price {Price}, amount {Amount}");
        }

        public void ChangePrice(double newPrice)
        {
            Price = newPrice;
        }

        public void ChangeQuantity(int newAmount)
        {
            Amount = newAmount;
        }
    }
}

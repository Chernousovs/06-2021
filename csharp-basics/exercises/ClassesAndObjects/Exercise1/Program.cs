using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product productMouse = new Product("Logitech mouse", 70.00, 14);
            Product phone = new Product("iPhone 5s", 999.99, 3);
            Product projector = new Product("Epson EB-U05", 440.46, 1);

            productMouse.PrintProduct();
            phone.PrintProduct();
            projector.PrintProduct();

            Console.WriteLine();

            productMouse.ChangePrice(44.75);
            productMouse.ChangeQuantity(10);
            productMouse.PrintProduct();

            phone.ChangePrice(1199.99);
            phone.ChangeQuantity(5);
            phone.PrintProduct();

            projector.ChangePrice(400.56);
            projector.ChangeQuantity(3);
            projector.PrintProduct();
        }
    }
}

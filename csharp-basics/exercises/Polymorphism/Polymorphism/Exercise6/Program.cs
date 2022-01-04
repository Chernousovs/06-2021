using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal zebra = new Zebra("Zebra", "John", 500.99, "Africa");
            Animal mouse = new Mouse("Mouse", "Mickey", 0.0019, "DisneyLand");
            Animal cat = new Cat("Cat", "Tom", "Domestic cat", 4.5, "Living room");
            Animal tiger = new Tiger("Tiger", "Tigger", 230.0, "Asia");

            Vegetable cabbage = new Vegetable(5);
            Vegetable carrot = new Vegetable(10);
            Vegetable potato = new Vegetable(50);
            Meat pork = new Meat(3);
            Meat chicken = new Meat(1);

            Console.WriteLine(zebra.ToString());
            zebra.MakeSound();
            zebra.Eat(cabbage);

            Console.WriteLine(mouse.ToString());
            mouse.MakeSound();
            mouse.Eat(carrot);

            Console.WriteLine(tiger.ToString());
            tiger.MakeSound();
            tiger.Eat(potato);

            Console.WriteLine(cat.ToString());
            cat.MakeSound();
            cat.Eat(chicken);
        }
    }
}

using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Zed A. Shaw", 
                eyes = "Blue", 
                teeth = "White", 
                hair = "Brown";

            int age = 35,
                inchHeight = 74,
                lbsWeight = 180;

            decimal cmHeight = Convert.ToDecimal(inchHeight * 2.54);

            double kgWeight = Math.Round(lbsWeight * 0.453592, 2), 
                totalResult = Convert.ToDouble(age) + Convert.ToDouble(cmHeight) + kgWeight;

            Console.WriteLine($"Let's talk about {name}.\n" +
                              $"He's {cmHeight} centimeters tall.\n" +
                              $"He's {kgWeight} kilos heavy.\n" +
                              "Actually, that's not too heavy.\n" +
                              $"He's got {eyes} eyes and {hair} hair.\n" +
                              $"His teeth are usually {teeth} depending on the coffee.");

            Console.WriteLine($"If I add {age}, {cmHeight} and {kgWeight} I get {Math.Round(totalResult, 2)}.");

            Console.ReadKey();
        }
    }
}
using System;
using System.IO;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            var repeat = true;

            do
            {
                Console.WriteLine("Geometry calculator:\n" +
                                  "Calculate the Area of a Circle\n" +
                                  "Calculate the Area of a Rectangle\n" +
                                  "Calculate the Area of a Triangle\n" +
                                  "Quit\n" +
                                  "Enter your choice (1-4):");
                Console.WriteLine();
                string choise = Console.ReadLine();

                switch (choise)
                {
                    case "1":
                        CalculateCircleArea();
                        break;
                    case "2":
                        CalculateRectangleArea();
                        break;
                    case "3":
                        CalculateTriangleArea();
                        break;
                    case "4":
                        Console.WriteLine("Good bye");
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("Check your input");
                        break;
                }
            } while (repeat);
        }

        private static void CalculateCircleArea()
        {
            Console.WriteLine("Enter circle radius");
            double r = Convert.ToDouble(Console.ReadLine());

            try
            { 
                var circleArea = Geometry.CircleArea(r);
                Console.WriteLine(circleArea);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void CalculateRectangleArea()
        {
            Console.WriteLine("Enter rectangle length:");
            double rectangleLength = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter rectangle width:");
            double rectangleWidth = Convert.ToDouble(Console.ReadLine());

            try
            {
                var rectangleArea = Geometry.RectangleArea(rectangleLength, rectangleWidth);
                Console.WriteLine(rectangleArea);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void CalculateTriangleArea()
        {
            Console.WriteLine("Enter length of a triangle’s base:");
            double trianleBaseLength = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter triangle’s height:");
            double triangleHeight = Convert.ToDouble(Console.ReadLine());

            try
            {
                var triangleArea = Geometry.TriangleArea(trianleBaseLength, triangleHeight);
                Console.WriteLine(triangleArea);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

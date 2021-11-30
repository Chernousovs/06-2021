using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To calculate your BMI, please enter data in metric units\n" +
                              "Enter Your weight in KG: ");

            double weightKg = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Your height in cm:");
            int heightCm = Convert.ToInt32(Console.ReadLine());
            double bmi = BmiCalculation(weightKg, heightCm);

            if (bmi <= 25 && bmi >= 18.5)
            {
                Console.WriteLine($"BMI is {bmi}, it is optimal index.");
            }
            else if (bmi > 25)
            {
                Console.WriteLine($"BMI is {bmi}, you have overweight.");
            }
            else if (bmi < 18.5)
            {
                Console.WriteLine($"BMI is {bmi}, you have underweight.");
            }
        }

        public static double BmiCalculation(double weightKg, int heightCm)
        {
            double weightPounds = weightKg * 2.20462;
            double heightInch = Convert.ToDouble(heightCm) * 0.393701;
            return Math.Round(weightPounds * 703 / Math.Pow(heightInch, 2), 2);
        }
    }
}

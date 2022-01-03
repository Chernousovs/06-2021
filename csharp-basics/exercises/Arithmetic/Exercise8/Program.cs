using System;
using System.Collections.Generic;


namespace Exercise8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter base pay");
            decimal basePay = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter hours worked");
            int hoursWorked = Convert.ToInt32(Console.ReadLine());
            string errorMessage = "Error, check input data";

            Console.WriteLine(DisplayTotalSalary(hoursWorked, basePay, errorMessage));
        }

        public static decimal TotalPay(decimal basePay, int hoursWorked)
        {
            decimal overtime = 0;
            int baseHours = 40;
            if (hoursWorked > 40)
            {
                overtime = basePay * (decimal) 1.5 * (hoursWorked - 40);
            }
            decimal totalSalary = baseHours * basePay + overtime;
            
            return totalSalary;
        }

        public static string DisplayTotalSalary(int hoursWorked, decimal basePay ,string errorMessage)
        {
            if ( 40 > hoursWorked || hoursWorked > 60 || basePay < 8)
            {
                return errorMessage;
            }
            else
            {
                return $"Employee's total Salary: {TotalPay(basePay, hoursWorked)}";
            }
        }
    }
}

using System;
using System.Collections.Generic;


namespace Exercise8
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter base pay");
            decimal basePay = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter hours worked");
            int hoursWorked = Convert.ToInt32(Console.ReadLine());
            string errorMessage = "Error, check input data";

            if ( 40 > hoursWorked || hoursWorked > 60 || basePay < 8)
            {
                Console.WriteLine(errorMessage);
            }
            else
            {
                Console.WriteLine($"Employee's total Salary: {TotalPay(basePay, hoursWorked)}");
            }
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
    }
}

using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
            int cars = 100,
                drivers = 28,
                passengers = 90,
                carsDriven = drivers, 
                carsNotDriven = cars - carsDriven ,
                seatsInACar = 4, 
                carpoolCapacity = seatsInACar * carsDriven;
            double averagePassengersPerCar = Convert.ToDouble(passengers) / Convert.ToDouble(carsDriven);


            Console.WriteLine($"There are {cars} cars available.\n" +
                              $"There are only {drivers} drivers available.\n" +
                              $"There will be {carsNotDriven} empty cars today.\n" +
                              $"We can transport {carpoolCapacity} people today.\n" +
                              $"We have {passengers} to carpool today.\n" +
                              $"We need to put about {Math.Round(averagePassengersPerCar, 2)} in each car.");
            Console.ReadKey();
        }
    }
}
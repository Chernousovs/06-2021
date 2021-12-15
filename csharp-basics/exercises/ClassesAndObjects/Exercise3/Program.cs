using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {

            FuelGauge fuelGauge = new FuelGauge(0.0);
            Ododmeter odometer = new Ododmeter(256000.0, fuelGauge);

            Console.WriteLine("Please enter how many kilometers you want to ride");
            int km = int.Parse(Console.ReadLine());

            for (var i = 0; i <= km; i++)
            {
                if (fuelGauge.CurrentFuelAmount > 0)
                {
                    odometer.IncrementCurrentMileage();
                }
                else
                {
                    do
                    {
                        fuelGauge.IncreaseAmountOFFuel();
                    } while (!fuelGauge.IsFull());
                }

                Console.WriteLine($"Your current mileage = {odometer.CurrentMileage}KM ;\n" +
                                  $"Your trip was {i} KM long\n" +
                                  $"Current fuel amount = {fuelGauge.CurrentFuelAmount}");
                Console.WriteLine();
            }
        }
    }
}

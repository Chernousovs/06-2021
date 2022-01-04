using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightPlanner
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var flightDestinationsList = File.ReadAllLines(@"..\..\..\FlightPlanner\flights.txt").ToList();

            Console.Write("What would you like to do:\n" +
                          "To display list of the cities press 1\n" +
                          "To exit program press #\n");
            
            var userEnter = Console.ReadLine();
            bool correctInput = false;
            List<string> possibleDestinationList = flightDestinationsList, 
                currentDestinationList = new List<string>();
            var flightHistory = new Dictionary<int, string>();

            do
            {
                switch (userEnter)
                {
                    case "#":
                        return;
                    case "1":
                        correctInput = true;
                        break;
                    default:
                        Console.WriteLine("Check your input");
                        break;
                }
            } while (!correctInput);

            do
            {
                foreach (var possibleDestination in possibleDestinationList)
                {
                    Console.WriteLine(possibleDestination);
                }

                userEnter = Console.ReadLine();
                if (userEnter == "#")
                {
                    return;
                }

                var cityToStart = userEnter;
                currentDestinationList = FindPossibleDestinations(cityToStart, flightDestinationsList);

                if (!currentDestinationList.Any())
                {
                    Console.WriteLine("Check your input");
                    continue;
                }
               
                possibleDestinationList = new List<string>(currentDestinationList);
                currentDestinationList.Clear();
                flightHistory.Add(flightHistory.Count(), cityToStart);

            } while (!HasReachedLastDestination(flightHistory));
            
            Console.WriteLine(string.Join(" => ", flightHistory.Select(o => o.Value)));
            
            Console.ReadKey();
        }

        public static List<string> FindPossibleDestinations(string cityToStart, List<string> flightDestinationsList)
        {
            List<string> list = new List<string>();

            foreach (var flightDestination in flightDestinationsList)
            {
                var cityToLook = flightDestination.Substring(0, flightDestination.IndexOf('-') - 1);
                if (!string.IsNullOrWhiteSpace(cityToStart) && cityToLook.ToUpper().Contains(cityToStart.ToUpper()))
                {
                    list.Add(flightDestination);
                }
            }

            return list;
        }

        public static bool HasReachedLastDestination(Dictionary<int, string> flightHistory)
        {
            return flightHistory.FirstOrDefault().Value == flightHistory.Last().Value && flightHistory.Count() > 1;
        }
    }
}

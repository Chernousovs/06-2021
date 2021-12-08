using System;

namespace Exercise9
{
    class RollTwoDice
    {
        static void Main(string[] args)
        {
            Console.Write("Desired sum: ");
            int sumToFind = int.Parse(Console.ReadLine());
            bool continueGame = false;
            do
            {
                
                Random rnd = new Random();
                int dice = rnd.Next(1, 7);
                int dice2 = rnd.Next(1, 7);
                int res = dice + dice2;
                Console.WriteLine($"{dice} and {dice2} = {res}");
                if (res == sumToFind)
                {
                    continueGame = true;
                }
            } while (!continueGame);
            

            
        }
    }
}

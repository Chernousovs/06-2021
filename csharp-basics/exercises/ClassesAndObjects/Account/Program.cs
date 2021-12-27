using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            Account bartosAccount = new Account("Barto's account",100.00);
            Account bartosSwissAccount = new Account("Barto's account in Switzerland",1000000.00);

            Console.WriteLine("Initial state");
            Console.WriteLine(bartosAccount);
            Console.WriteLine(bartosSwissAccount);

            bartosAccount.Withdrawal(20);
            Console.WriteLine("Barto's account balance is now: " + bartosAccount.Balance());
            bartosSwissAccount.Deposit(200);
            Console.WriteLine("Barto's Swiss account balance is now: " + bartosSwissAccount.Balance());

            Console.WriteLine("Final state");
            Console.WriteLine(bartosAccount);
            Console.WriteLine(bartosSwissAccount);

            Account A = new Account("A", 100.0);
            Account B = new Account("B", 0.0);
            Account C = new Account("C", 0.0);

            Console.WriteLine();
            Console.Write("Please enter HOW MUCH you want to transfer from A to B :");
            double howMuch = Convert.ToDouble(Console.ReadLine());
            Transfer(ref A, ref B, howMuch);
            Console.WriteLine($"You successfully transferred {howMuch} bucks to B account\n" +
                              $"B account balance now is:  {B.Balance()}");
            Console.WriteLine();
            Console.Write("Please enter HOW MUCH you want to transfer from B to C :");
            howMuch = Convert.ToDouble(Console.ReadLine());
            Transfer(ref B, ref C, howMuch);
            Console.WriteLine($"You successfully transferred {howMuch} bucks to C account\n" +
                              $"C account balance now is:  {C.Balance()}");

            Console.ReadKey();
        }

        public static void Transfer(ref Account from, ref Account to,  double howMuch)
        {
            from.Withdrawal(howMuch);
            to.Deposit(howMuch);
        }
    }
}

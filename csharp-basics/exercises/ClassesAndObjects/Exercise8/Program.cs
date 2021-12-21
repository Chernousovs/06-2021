using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit, withdrowal;
            int accountTerm;
            
            Console.Write($"How much money is in the account?: ");
            double startingAmount = Convert.ToDouble(Console.ReadLine());
            SavingsAccount savingsAccount = new SavingsAccount(startingAmount);

            Console.Write("Enter the annual interest rate: ");
            double annualInterestRate = Convert.ToDouble(Console.ReadLine());
            savingsAccount.SetAnnualInterest(annualInterestRate);
            
            Console.WriteLine("How long has the account been opened? ");
            accountTerm = Convert.ToInt32(Console.ReadLine());
            savingsAccount.SetAccountTerm(accountTerm);
            
            for (var i = 1; i <= savingsAccount.AccountTerm; i++)
            {
                Console.Write($"Enter amount deposited for month: {i}: ");
                deposit = Convert.ToDouble(Console.ReadLine());
                savingsAccount.AddAmountOfDeposit(deposit);
                Console.WriteLine();

                Console.Write($"Enter amount withdrawn for {i}: ");
                withdrowal = Convert.ToDouble(Console.ReadLine());
                savingsAccount.SubtractAmountWithdrawal(withdrowal);
                savingsAccount.CalculateMonthlyInterest();
                Console.WriteLine();
            }

            Console.WriteLine($"Total deposited: {Convert.ToDecimal(savingsAccount.TotalDeposited).ToString("C")}");
            Console.WriteLine($"Total withdrawn: {Convert.ToDecimal(savingsAccount.TotalWithdrawn).ToString("C")}");
            Console.WriteLine($"Interest Earned: {Convert.ToDecimal(savingsAccount.InterestEarned).ToString("C")}");
            Console.WriteLine($"Ending balance: {Convert.ToDecimal(savingsAccount.Balance).ToString("C")}");
        }
    }
}

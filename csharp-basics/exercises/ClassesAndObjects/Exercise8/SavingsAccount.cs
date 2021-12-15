using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    public class SavingsAccount
    {
        private double _annualInterestRate;

        public SavingsAccount(double accountStartingBalance)
        {
            Balance = accountStartingBalance;
        }

        public int AccountTerm { get; private set; }

        public double TotalDeposited { get; private set; }

        public double TotalWithdrawn { get; private set; }

        public double Balance { get; private set; }

        public double InterestEarned { get; private set; }

        public void SetAccountTerm(int accountTerm)
        {
            AccountTerm = accountTerm;
        }

        public void SetAnnualInterest(double annualInterestRate)
        {
            _annualInterestRate = annualInterestRate / 100;
        }

        public void SubtractAmountWithdrawal(double withdrawn)
        {
            if (withdrawn <= Balance)
            {
                TotalWithdrawn += withdrawn;
                Balance -= withdrawn;
            }
            else
            {
                Console.WriteLine("There are not enough funds on the savings account");
            }
        }

        public void AddAmountOfDeposit(double deposit)
        {
            TotalDeposited += deposit;
            Balance += deposit;
        }

        public void CalculateMonthlyInterest()
        {
            Balance += Balance * (_annualInterestRate / 12);
            InterestEarned +=  Balance * (_annualInterestRate / 12);
        }
    }
}

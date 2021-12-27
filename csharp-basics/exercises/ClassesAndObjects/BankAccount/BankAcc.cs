using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAcc
    {
        public BankAcc(string name, decimal balance)
        {
            Name = name;
            Balance = balance;
        }

        public string Name { get; }

        public decimal Balance { get; }

        public string ShowUserNameAndBalance()
        {
            if (Balance > 0)
            {
                return $"{Name}, {Balance:C}";
            }
            else
            {
                return $"{Name}, -{Math.Abs(Balance):C}";
            }
        }
    }
}

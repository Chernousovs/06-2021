using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAcc benbenAcc = new BankAcc("Benson", -17.25m);

            Console.WriteLine(benbenAcc.ShowUserNameAndBalance());

            Console.ReadKey();
        }
    }
}

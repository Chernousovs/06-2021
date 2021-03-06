using System.Runtime.InteropServices;

namespace Account
{
    public class Account
    {
        private string _name;
        private double _money;
        

        public Account(string name, double money)
        {
            _name = name;
            _money = money;
        }

        public double Withdrawal(double withdrawn)
        {
            return _money -= withdrawn;
        }

        public void Deposit(double deposit)
        {
            _money += deposit;
        }

        public double Balance()
        {
            return _money;
        }

        public override string ToString()
        {
            return $"{_name}: {_money}";
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }
    }
}

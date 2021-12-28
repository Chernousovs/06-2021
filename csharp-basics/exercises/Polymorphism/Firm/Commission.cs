using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    public class Commission : Hourly
    {
        private double _totalSalesMadeByEmployee;

        public Commission(string eName, string eAddress, string ePhone, string socSecNumber, 
            double rate, double employeeCommissionRate)
            : base(eName, eAddress, ePhone, socSecNumber, rate)
        {
            EmployeeCommissionRate = employeeCommissionRate;
        }

        public double EmployeeCommissionRate { get; private set; }

        public void AddSales(double totalSales)
        {
            _totalSalesMadeByEmployee = totalSales;
        }

        public override double Pay()
        {
            var payment = base.Pay() + EmployeeCommissionRate * _totalSalesMadeByEmployee;
            _totalSalesMadeByEmployee = 0;
            return payment;
        }

        public override string ToString()
        {
            var result = _totalSalesMadeByEmployee.ToString();
            result += "\nTotal sales: " + Pay();
            return result;
        }
    }
}

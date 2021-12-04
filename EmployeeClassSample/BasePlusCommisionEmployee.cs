using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClassSample
{
    public class BasePlusCommissionEmployee : CommissionEmployee
    {
        private double _baseSalary;

        public double BaseSalary
        {
            get { return _baseSalary; }
            set { _baseSalary = value; }
        }

        public BasePlusCommissionEmployee(double baseSalary, double grossSales, double commisionRate)
        {
            BaseSalary = baseSalary;
            GrossSales = grossSales;
            CommisionRate = commisionRate;
        }

        public override double Earnings()
        {
            return base.Earnings() + BaseSalary;

        }
        public override string ToString()
        {
            string toString = "Base Plus Commissin Employee : " + FirstName + " " + LastName + " - SSN : " + SSN + " - Kazanç : " + Earnings().ToString();
            return toString;
        }
    }
}

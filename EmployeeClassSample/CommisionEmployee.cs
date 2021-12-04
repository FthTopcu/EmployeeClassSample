using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClassSample
{
    public class CommissionEmployee : Employee
    {
        private double _grossSales;

        public double GrossSales
        {
            get { return _grossSales; }
            set { _grossSales = value; }
        }
        private double _commisionRate;

        public double CommisionRate
        {
            get { return _commisionRate; }
            set { _commisionRate = value; }
        }

        public CommissionEmployee(double grossSales,double commisionRate)
        {
            GrossSales = grossSales;
            CommisionRate = commisionRate;
        }
        public CommissionEmployee()
        {

        }

        public override double Earnings()
        {
            return GrossSales * CommisionRate;
        }

        public override string ToString()
        {
            string toString = "Commission Employee : " + FirstName + " " + LastName + " - SSN : " + SSN + " - Kazanç : " + Earnings().ToString();
            return toString;
        }
    }
}

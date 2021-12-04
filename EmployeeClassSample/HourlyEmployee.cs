using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClassSample
{
    public class HourlyEmployee:Employee
    {
        private double _wage;

        public double Wage
        {
            get { return _wage; }
            set { _wage = value; }
        }
        private double _hour;

        public double Hour
        {
            get { return _hour; }
            set { _hour = value; }
        }

        public HourlyEmployee(double wage, double hour)
        {
            Wage = wage;
            Hour = hour;
        }

        public override double Earnings()
        {
            if (Hour <= 40)
            {
                return Wage * Hour;
            }
            else
                return 40 * Wage + (Hour - 40) * Wage * 1.5;
        }

        public override string ToString()
        {
            string toString = "Hourly Employee : " + FirstName + " " + LastName + " - SSN : " + SSN + " - Kazanç : " + Earnings().ToString();
            return toString;
        }
    }
}

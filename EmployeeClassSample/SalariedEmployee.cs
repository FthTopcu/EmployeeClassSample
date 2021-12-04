using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClassSample
{
    public class SalariedEmployee : Employee
    {

        private double _weaklySalary;

        public double WeaklySalary
        {
            get { return _weaklySalary; }
            set { WeaklySalary = value; }
        }

        public SalariedEmployee(double weaklySalary)
        {
            _weaklySalary = weaklySalary;
        }

        public override double Earnings()
        {
            return _weaklySalary;
            
        }
        public override string ToString()
        {
            string toString = "Salaried Employee : " + FirstName + " " + LastName + " - SSN : " + SSN + " - Kazanç : " + Earnings().ToString();
            return toString;
        }
    }
}

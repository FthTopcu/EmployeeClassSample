using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClassSample
{
    public abstract class Employee
    {
        private string _firstName;

        public string  FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        private string _sSN;

        public string SSN
        {
            get { return _sSN; }
            set { _sSN = value; }
        }
        public Employee()
        {

        }
        public abstract double Earnings();

    }
}

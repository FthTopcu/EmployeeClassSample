using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClassSample
{
    class Program
    {
        static void Main()
        {
            Employee employee1 = new SalariedEmployee(4555)
            {
                FirstName = "Fatih",
                LastName = "Topcu",
                SSN = "12456789"
            };
            Employee employee2 = new HourlyEmployee(15, 35)
            {
                FirstName = "Murat",
                LastName = "Yılmaz",
                SSN = "12345677"
            };
            Employee employee3 = new CommissionEmployee(456, 25)
            {
                FirstName = "Ali",
                LastName = "Koşucu",
                SSN = "866467"
            };
            CommissionEmployee employee4 = new BasePlusCommissionEmployee(2000, 450, 24)
            {
                FirstName = "Amet",
                LastName = "Demir",
                SSN = "753648"
            };
            Console.WriteLine(employee1.ToString());
            Console.WriteLine(employee2.ToString());
            Console.WriteLine(employee3.ToString());
            Console.WriteLine(employee4.ToString());

            Console.ReadKey();
        }
    }
}

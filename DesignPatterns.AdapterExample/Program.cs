using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterExample
{
    class Program
    {
        static void Main(string[] args)
        {

            IEmployee employee1 = new Employee();

            IEmployee employee2 = new EmployeeFromAnotherAppAdapter();


            employee1.ShowHappiness();
            employee2.ShowHappiness();


        }
    }
}

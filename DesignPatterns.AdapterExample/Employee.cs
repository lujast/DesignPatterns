using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterExample
{
    public class Employee : IEmployee
    {
        public void ShowHappiness()
        {
            Console.WriteLine("Employee shows his happiness");
        }
    }
}

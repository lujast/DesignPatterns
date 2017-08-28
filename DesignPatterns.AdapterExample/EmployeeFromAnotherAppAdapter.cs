using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterExample
{
    public class EmployeeFromAnotherAppAdapter : IEmployee
    {
        private readonly EmployeeFromAnotherApp employeeFromAnotherApp = new EmployeeFromAnotherApp();


        public void ShowHappiness()
        {
            this.employeeFromAnotherApp.ShowSmile();
        }
    }
}

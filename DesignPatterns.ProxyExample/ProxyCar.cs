using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ProxyExample
{
    public class ProxyCar : ICar
    {

       
        private ICar car;

        public ProxyCar()
        {
            this.car = new Car();
        }

        public Driver Driver { get; set; }

        public void Drive()
        {
            if (Driver.Age < 18)
            {
                Console.WriteLine("Driver is to young to drive a car");
            }
            else
            {
                this.car.Drive();
            }
            
        }
    }
}

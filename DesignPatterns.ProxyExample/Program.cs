using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ProxyExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Driver d1 = new Driver { Age = 17 };
            Driver d2 = new Driver { Age = 20 };

            ICar car = new ProxyCar();
            (car as ProxyCar).Driver = d1;
            car.Drive();
            (car as ProxyCar).Driver = d2;
            car.Drive();
        }
    }
}

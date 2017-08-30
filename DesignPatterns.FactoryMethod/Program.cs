using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new ConcreteFactory();

            IProduct product1 = factory.GetProduct("A");
            IProduct product2 = factory.GetProduct("B");

            product1.GetProductName();
            product2.GetProductName();

        }
    }
}

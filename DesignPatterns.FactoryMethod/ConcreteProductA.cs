using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    public class ConcreteProductA : IProduct
    {
        public void GetProductName()
        {
            Console.WriteLine("I am product of type A");
        }
    }
}

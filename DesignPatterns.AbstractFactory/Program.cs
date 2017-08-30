using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            IFactory factory = new Factory();

            var product=factory.GetProduct();
            var anotherProduct = factory.GetAnotherProduct();

            product.GetProductName();
            anotherProduct.GetProductName();

        }
    }
}

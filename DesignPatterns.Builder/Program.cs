using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();


            var product=director.BuildProduct(new ConcreteBuilder());

            Console.WriteLine(product.PartA);
            Console.WriteLine(product.PartB);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.VisitorExample
{

    //Allows to add methods to classes without much altering those classes.
    //Allows to extend some classes functionality without editing them by defining external classes.
    
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product() { Id = 1, Name = "Product1", Price = 10.0M };

            Console.WriteLine($"product price before tax is {product.Price:0.00}");

            product.Accept(new TaxVisitor());

            Console.WriteLine($"product price after taxing is {product.Price:0.00}");

            product.Accept(new PriceCutVisitor());

            Console.WriteLine($"product price after price cutting is {product.Price:0.00}");
        }
    }
}

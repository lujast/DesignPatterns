using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class ConcreteBuilder : IBuilder
    {
        private Product product = new Product();

        public void BuildPartA()
        {
            this.product.PartA = "Part A was build by Concrete builder";
        }

        public void BuildPartB()
        {
            this.product.PartB = "Part B was build by Concrete builder";
        }

        public Product GetProduct()
        {
            return this.product;
        }
    }
}

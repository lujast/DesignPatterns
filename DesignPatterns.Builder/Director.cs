using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class Director
    {

        public Product BuildProduct(IBuilder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
            return builder.GetProduct();
        }


    }
}

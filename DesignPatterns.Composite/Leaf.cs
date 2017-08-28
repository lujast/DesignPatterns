using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class Leaf : IComponent
    {
        private string name;

        public Leaf(string name)
        {
            this.name = name;
        }


        public void Operation()
        {
            Console.WriteLine($"Operation on component: {name}");
        }
    }
}

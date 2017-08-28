using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class ConcreteDecorator : Decorator
    {
        public ConcreteDecorator(IComponent component) : base(component)
        {
        }

        public override void AddedBehavior()
        {
            Console.WriteLine("Additinal behavior from Concrete Decorator");
        }


    }
}

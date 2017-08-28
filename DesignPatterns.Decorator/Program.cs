using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent component = new ConcreteComponent();
            component.Operation();
            Console.WriteLine();
            IComponent componentDecorated = new ConcreteDecorator(component);
            componentDecorated.Operation();



        }
    }
}

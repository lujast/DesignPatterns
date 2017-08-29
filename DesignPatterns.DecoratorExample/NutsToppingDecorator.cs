using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorExample
{
    public class NutsToppingDecorator : IceScreamDecorator
    {
        public NutsToppingDecorator(IIceScreamMachine iceScreamMachine) : base(iceScreamMachine)
        {
        }

        public override void AddToppings()
        {
            Console.WriteLine($"Nuts toppings was added");
        }
    }
}

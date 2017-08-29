using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorExample
{
    public class PeanutToppingDecorator : IceScreamDecorator
    {
        public PeanutToppingDecorator(IIceScreamMachine iceScreamMachine) : base(iceScreamMachine)
        {
        }

        public override void AddToppings()
        {
            Console.WriteLine($"Peanuts toppings was added");
        }
    }
}

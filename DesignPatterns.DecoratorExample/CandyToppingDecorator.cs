using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorExample
{
    public class CandyToppingDecorator : IceScreamDecorator
    {
        public CandyToppingDecorator(IIceScreamMachine iceScreamMachine) : base(iceScreamMachine)
        {
        }

        public override void AddToppings()
        {
            Console.WriteLine($"Canddy toppings was added");
        }
    }
}

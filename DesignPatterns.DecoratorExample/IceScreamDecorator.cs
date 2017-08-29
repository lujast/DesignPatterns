using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorExample
{
    public abstract class IceScreamDecorator : IIceScreamMachine
    {
        protected IIceScreamMachine iceScreamMachine;

        public IceScreamDecorator(IIceScreamMachine iceScreamMachine)
        {
            this.iceScreamMachine = iceScreamMachine;
        }

        public void DoIceScream()
        {
            iceScreamMachine.DoIceScream();
            this.AddToppings();
        }

        public abstract void AddToppings();
    }
}

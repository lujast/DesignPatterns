using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public abstract class Decorator : IComponent
    {
        private IComponent componennt;


        public Decorator(IComponent component)
        {
            this.componennt = component;
        }

        public void Operation()
        {
            this.componennt.Operation();
            this.AddedBehavior();
        }


        public abstract void AddedBehavior();


    }
}

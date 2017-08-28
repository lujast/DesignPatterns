using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public class ConcreteAbstraction : Abstraction
    {
        public ConcreteAbstraction(Implementator implementator) : base(implementator)
        {
        }

        public override void AbstrationOperation()
        {
            this.implementator.ImplementatorOperation();
        }
    }
}

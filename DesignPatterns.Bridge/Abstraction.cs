using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public abstract class Abstraction
    {
        protected Implementator implementator;


        public Abstraction(Implementator implementator)
        {
            this.implementator = implementator;
        }

        public abstract void AbstrationOperation();

    }
}

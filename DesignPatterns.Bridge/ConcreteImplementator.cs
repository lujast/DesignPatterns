using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public class ConcreteImplementator : Implementator
    {
        public override void ImplementatorOperation()
        {
            Console.WriteLine("Concrete Implementator's method was run");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    class Program
    {
        static void Main(string[] args)
        {

            Abstraction a1 = new ConcreteAbstraction(new ConcreteImplementator());
            a1.AbstrationOperation();


        }
    }
}

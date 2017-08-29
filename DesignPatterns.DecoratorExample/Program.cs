using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IIceScreamMachine m1 = new IceScreamMachine("ice scream with 2 balls");
            m1.DoIceScream();
            Console.WriteLine();
            IIceScreamMachine m2 = new CandyToppingDecorator(m1);
            m2.DoIceScream();
            Console.WriteLine();
            IIceScreamMachine m3 = new PeanutToppingDecorator(m2);
            m3.DoIceScream();

        }
    }
}

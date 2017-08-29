using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorExample
{
    public class IceScreamMachine : IIceScreamMachine
    {

        private string description;

        public IceScreamMachine(string description)
        {
            this.description = description;
        }

        public void DoIceScream()
        {
            Console.WriteLine($"Ice scream: {description} ");
        }
    }
}

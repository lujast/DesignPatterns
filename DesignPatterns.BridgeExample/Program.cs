using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BridgeExample
{
    class Program
    {
        static void Main(string[] args)
        {

            var rc = new RemoteControl();

            rc.Appliance = new TV();
            rc.TurnOn();
            rc.TurnOff();

            rc.Appliance = new Radio();

            rc.TurnOn();
            rc.TurnOff();


        }
    }
}

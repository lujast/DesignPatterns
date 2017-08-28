using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BridgeExample
{
    public class TV : Appliance
    {
        public override void StartAppliance()
        {
            Console.WriteLine("Television was turned on");
        }

        public override void StopAppliance()
        {
            Console.WriteLine(  "Television was turned off");
        }
    }
}

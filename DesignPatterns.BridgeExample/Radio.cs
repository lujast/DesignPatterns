using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BridgeExample
{
    public class Radio : Appliance
    {
        public override void StartAppliance()
        {
            Console.WriteLine("Radio was turned on");
        }

        public override void StopAppliance()
        {
            Console.WriteLine("Radio was turned off");
        }
    }
}

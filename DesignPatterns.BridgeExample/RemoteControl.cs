using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BridgeExample
{
    public class RemoteControl : Switch
    {
        public override void TurnOn()
        {
            Console.WriteLine("button on Remote Control was clicked");
            this.Appliance.StartAppliance();
        }

        public override void TurnOff()
        {
            Console.WriteLine("button on Remote Control was clicked");
            this.Appliance.StopAppliance();
        }
    }
}

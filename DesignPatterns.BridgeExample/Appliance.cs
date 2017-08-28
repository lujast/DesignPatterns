using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BridgeExample
{
    public abstract class Appliance
    {

        public abstract void StartAppliance();
        public abstract void StopAppliance();
    }
}

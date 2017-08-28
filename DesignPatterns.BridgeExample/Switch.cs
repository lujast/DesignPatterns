using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BridgeExample
{
    public abstract class Switch
    {
        protected Appliance appliance;

        public Appliance Appliance
        {
            get
            {
                return this.appliance;
            }
            set
            {
                Console.WriteLine($"Remote control change its appliance to {value.GetType().Name}");
                this.appliance = value;
            }
        }

        public abstract void TurnOn();

        public abstract void TurnOff();


    }
}

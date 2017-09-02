using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Flyweight
{
    public class ConcreteFlyweight : IFlyweight
    {
        private IntrinsicState intrinsicState;

        public ConcreteFlyweight(IntrinsicState intrinsicState)
        {
            this.intrinsicState = intrinsicState;
        }

        public int Id { get; set; }

        public ExtrinsicState GetExtrinsicState(bool trigger)
        {

            var extrinsicState = new ExtrinsicState();
            extrinsicState.Status= trigger == true ?  true :  false;
            return extrinsicState;
        }

        public IntrinsicState GetIntrinsicState()
        {
            return this.intrinsicState;
        }
    }
}

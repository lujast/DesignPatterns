using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Flyweight
{
    public class FlyweightManager
    {
        private Dictionary<int, IFlyweight> flyweights = new Dictionary<int, IFlyweight>();
        private IntrinsicState intrinsicStateForAll = new IntrinsicState();


        public IFlyweight GetFlyweight(int id)
        {
            if (!flyweights.ContainsKey(id))
            {
                var flyweight = new ConcreteFlyweight(this.intrinsicStateForAll) { Id = id };
                flyweights.Add(id, flyweight);

            }

            return flyweights[id];
        }

    }
}

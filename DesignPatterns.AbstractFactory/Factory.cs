using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class Factory : IFactory
    {
        private bool IsTodaysDayEven= DateTime.Now.Day % 2 == 0;

        public IAnotherProduct GetAnotherProduct()
        {
            if (IsTodaysDayEven)
            {
                return new ConcreteAnotherProductA();
            }
            else
            {
                return new ConcreteAnotherProductB();
            }
        }


        public IProduct GetProduct()
        {
            if (IsTodaysDayEven)
            {
                return new ConcreteProductA();
            }
            else
            {
                return new ConcreteProductB();
            }
        }
    }
}

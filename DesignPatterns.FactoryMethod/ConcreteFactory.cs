using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    public class ConcreteFactory : IFactory
    {
        public IProduct GetProduct(string type)
        {
            switch (type)
            {
                case "A":
                    return new ConcreteProductA();


                case "B":
                    return new ConcreteProductB();

                default:
                    return null;

            }
        }
    }
}

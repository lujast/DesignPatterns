using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyExample
{
    public class HandFightStrategy : IFightStrategy
    {
        public void Fight()
        {
            Console.WriteLine("I am fighting using karate");
        }
    }
}

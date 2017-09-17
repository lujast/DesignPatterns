using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyExample
{
    public class GunFightStrategy : IFightStrategy
    {
        public void Fight()
        {
            Console.WriteLine("I shooting using gun");
        }
    }
}

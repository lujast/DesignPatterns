using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyExample
{
    public class SwordFightStrategy : IFightStrategy
    {
        public void Fight()
        {
            Console.WriteLine("I am now fighting using sword");

        }
    }
}

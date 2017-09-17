using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyExample
{
    class Program
    {
        static void Main(string[] args)
        {

            var commando = new Commando();
            commando.Fight();
            commando.SetFightStrategy(new HandFightStrategy());
            commando.Fight();
            commando.SetFightStrategy(new SwordFightStrategy());
            commando.Fight();
            commando.SetFightStrategy(new GunFightStrategy());
            commando.Fight();
            commando.SetFightStrategy(new SwordFightStrategy());
            commando.Fight();

        }
    }
}

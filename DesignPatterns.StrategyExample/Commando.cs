using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyExample
{
    public class Commando
    {
        private IFightStrategy fightStrategy;

        public void SetFightStrategy(IFightStrategy fightStrategy)
        {
            this.fightStrategy = fightStrategy;
        }


        public void Fight()
        {
            if (fightStrategy != null)
            {
                this.fightStrategy.Fight();
            }
            
        }

    }
}

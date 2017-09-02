using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethodExample
{
    public abstract class AbstractBattleGeneral
    {
        public BattleResult TakePartInTheBattle()
        {
            
            this.PreparePositions();
            this.Attactk();
            var battleResult = this.CheckBattleResult();

            return battleResult;
        }


        public abstract void PreparePositions();

        public abstract void Attactk();

        public abstract BattleResult CheckBattleResult();


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethodExample
{
    public class SeaAdmiral : AbstractBattleGeneral
    {
        public override void Attactk()
        {
            Console.WriteLine("Admiral command to start borading");
        }

        public override BattleResult CheckBattleResult()
        {
            return BattleResult.lose;
        }

        public override void PreparePositions()
        {
            Console.WriteLine("Sailors take theirs positions");
        }
    }
}

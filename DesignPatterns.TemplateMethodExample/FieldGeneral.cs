using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethodExample
{
    public class FieldGeneral : AbstractBattleGeneral
    {
        public override void Attactk()
        {
            Console.WriteLine("Field General command to start fighting");
        }

        public override BattleResult CheckBattleResult()
        {
            return BattleResult.win;
        }

        public override void PreparePositions()
        {
            Console.WriteLine("Field General sent pathfinders and start taking positions");
        }
    }
}

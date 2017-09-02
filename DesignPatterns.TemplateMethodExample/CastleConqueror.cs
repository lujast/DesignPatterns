using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethodExample
{
    public class CastleConqueror : AbstractBattleGeneral
    {
        public override void Attactk()
        {
            Console.WriteLine("Castle is beeing attacked");
        }

        public override BattleResult CheckBattleResult()
        {
            return BattleResult.win;
        }

        public override void PreparePositions()
        {
            Console.WriteLine("Castle is beeing surrounded by army");
        }
    }
}

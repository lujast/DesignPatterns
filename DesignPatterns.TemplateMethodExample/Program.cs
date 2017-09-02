using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var fieldGeneral = new FieldGeneral();
            var admiral = new SeaAdmiral();
            var castleConqueror = new CastleConqueror();

            var generals = new List<AbstractBattleGeneral>();
            generals.Add(fieldGeneral);
            generals.Add(admiral);
            generals.Add(castleConqueror);


            foreach (var general in generals)
            {
                var battleResult = general.TakePartInTheBattle();
                Console.WriteLine($"Battle result is : {battleResult}");
                Console.WriteLine();
            }



        }
    }
}

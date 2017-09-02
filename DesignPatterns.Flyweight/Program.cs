using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {

            var flyweightDirector = new FlyweightManager();

            var f1 = flyweightDirector.GetFlyweight(1);
            var f2 = flyweightDirector.GetFlyweight(2);
            var f3 = flyweightDirector.GetFlyweight(3);
            var f4 = flyweightDirector.GetFlyweight(4);
            var f5 = flyweightDirector.GetFlyweight(1);
            var f6 = flyweightDirector.GetFlyweight(2);

            Console.WriteLine($"f1 = {f1.Id}");
            Console.WriteLine($"f2 = {f2.Id}");
            Console.WriteLine($"f3 = {f3.Id}");
            Console.WriteLine($"f4 = {f4.Id}");
            Console.WriteLine($"f5 = {f5.Id}");
            Console.WriteLine($"f6 = {f6.Id}");
            Console.WriteLine(f1.GetExtrinsicState(true) == f5.GetExtrinsicState(true));
        }
    }
}

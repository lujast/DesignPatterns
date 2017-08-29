using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    public class Facade
    {
        public void Dosomething()
        {
            var c1 = new Class1();
            var c2 = new Class2();
            var c3 = new Class3();

            Console.WriteLine("Rersponse from facade: ");
            c1.DoTask();
            c2.DoTask();
            c3.DoTask();

        }


    }
}

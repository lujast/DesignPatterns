using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {

            IPrototype original = new ConcretePrototype() { Id = 1, Name = "Original" };
            (original as ConcretePrototype).SetDbData();

            var pm = new PrototypeManager();


            pm.AddPrototype(original);

            var copyShallow = pm.GetPrototype(0, false);



            var copyDeep = pm.GetPrototype(0, true);

            Console.WriteLine((original as ConcretePrototype).GetDataFromDb()  == (copyShallow as ConcretePrototype).GetDataFromDb() );
            Console.WriteLine((original as ConcretePrototype).GetDataFromDb() == (copyDeep as ConcretePrototype).GetDataFromDb());
        }
    }
}

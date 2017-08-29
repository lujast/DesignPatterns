using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    class Program
    {
        static void Main(string[] args)
        {


            ISubject s1 = new ConcreteSubject();
            s1.Operation();
            Console.WriteLine();

            ISubject proxys1 = new ProxySubject(s1);
            proxys1.Operation();



        }
    }
}

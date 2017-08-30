using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = Singleton.GetInstance();


            Console.WriteLine(s1.GetNumber());
            Console.WriteLine(s1.GetDateTime());

            System.Threading.Thread.Sleep(2000);
            var s2 = Singleton.GetInstance();

            Console.WriteLine(s2.GetNumber());
            Console.WriteLine(s2.GetDateTime());



        }
    }
}

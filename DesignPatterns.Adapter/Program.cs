using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {

            Target target = new Target();
            Target targetUsingAdapter = new Adapter();
            target.Request();
            targetUsingAdapter.Request();

        }
    }
}

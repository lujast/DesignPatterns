using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Request called from Target");
        }
    }
}

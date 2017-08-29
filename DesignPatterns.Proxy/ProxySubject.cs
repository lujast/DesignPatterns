using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    public class ProxySubject : ISubject
    {
        private ISubject subject;

        public ProxySubject(ISubject subject)
        {
            this.subject = subject;
        }
        


        public void Operation()
        {
            Console.WriteLine("Additional infors from ProxyObject");
            subject.Operation();
        }
    }
}

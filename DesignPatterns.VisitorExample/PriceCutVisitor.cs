using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.VisitorExample
{
    public class PriceCutVisitor : IVisitor
    {
        public void Visit(IVisitable subject)
        {
            (subject as Product).Price-=  0.5M * (subject as Product).Price;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.VisitorExample
{
    public class TaxVisitor : IVisitor
    {

        public void Visit(IVisitable subject)
        {
            (subject as Product).Price += 0.22M * (subject as Product).Price;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.VisitorExample
{
    public interface IVisitor
    {
        void Visit(IVisitable subject);
    }
}

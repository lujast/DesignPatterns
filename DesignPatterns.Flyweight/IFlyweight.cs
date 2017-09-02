using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Flyweight
{
    public interface IFlyweight
    {
        int Id { get; set; }
        IntrinsicState GetIntrinsicState();
        ExtrinsicState GetExtrinsicState(bool trigger);

    }
}

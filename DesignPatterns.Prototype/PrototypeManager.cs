using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    public class PrototypeManager
    {
        private List<IPrototype> prototypes= new List<IPrototype>();

        public IPrototype GetPrototype(int number, bool deepCopy)
        {
           

            if (number >= 0 && number < prototypes.Count)
                return prototypes[number].Clone(deepCopy);
            else
                return null;
        }

        public void AddPrototype(IPrototype prototype)
        {
            this.prototypes.Add(prototype);
        }

    }
}

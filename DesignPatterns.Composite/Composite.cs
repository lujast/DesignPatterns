using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class Composite : IComponent
    {
        private List<IComponent> components = new List<IComponent>();

        private string name;

        public Composite(string name)
        {
            this.name = name;
        }

        public void AddComponent(IComponent component)
        {
            this.components.Add(component);
        }

        public void RemoveComponent(IComponent component)
        {
            this.components.Remove(component);
        }

        public void Operation()
        {
            Console.WriteLine($"Operation on component: {name}");
            foreach (var component in this.components)
            {
                component.Operation();
            }
        }
    }
}

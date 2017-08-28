using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CompositeExample
{
    public class Supervisor : IEmployee
    {
        private string name;
        private int happinessRate;
        private List<IEmployee> successors = new List<IEmployee>();


        public Supervisor(string name, int happinessRate)
        {
            this.name = name;
            this.happinessRate = happinessRate;

        }
        public void ShowHappiness(int deep)
        {
            Console.Write($"{new String('\t',deep)}Supervisor name: {name}, happiness: {happinessRate}\n");
            deep++;
            foreach (var employee in this.successors)
            {

                employee.ShowHappiness(deep);
            }
        }


        public void AddSuccessor(IEmployee employee)
        {
            this.successors.Add(employee);
        }

        public void RemoveSuccessor(IEmployee employee)
        {
            this.successors.Remove(employee);
        }
    }
}


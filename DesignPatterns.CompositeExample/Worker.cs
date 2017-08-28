using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CompositeExample
{
    public class Worker : IEmployee
    {
        private string name;
        private int happinessRate;

        public Worker(string name, int happinessRate)
        {
            this.name = name;
            this.happinessRate = happinessRate;
        }


        public void ShowHappiness(int deep)
        {
            Console.Write($"{new String('\t',deep)}Worker name: {name}, happiness rate: {happinessRate}\n");
        }
    }
}

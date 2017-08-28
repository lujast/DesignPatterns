using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CompositeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Supervisor CEO = new Supervisor("CEO", 5);
            Worker CEOSecretary = new Worker("CEO Secretary", 10);
            Supervisor CEOFirstSuccessor = new Supervisor("CEO First Successor", 3);
            Worker CEOSecondSuccessor = new Worker("CEO Second Successor", 4);
            Supervisor CTO = new Supervisor("CTO", 3);
            Worker CTOSecretary = new Worker("CTO Secretary", 7);
            Worker CTOWorker1 = new Worker("CTO Worker1", 3);
            Worker CTOWorker2 = new Worker("CTO Worker2", 4);

            CEO.AddSuccessor(CEOSecretary);
            CEO.AddSuccessor(CEOFirstSuccessor);
            CEO.AddSuccessor(CEOSecondSuccessor);
            CEOFirstSuccessor.AddSuccessor(CTO);
            CTO.AddSuccessor(CTOSecretary);
            CTO.AddSuccessor(CTOWorker1);
            CTO.AddSuccessor(CTOWorker2);


            CEO.ShowHappiness(0);


        }
    }
}

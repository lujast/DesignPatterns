using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandExample
{
    public class AutomaticTrain
    {
        private Position actualPosition;
        private int numberOfStations;
        private int totalStopTime;

        public Position ActualPosition { get { return this.actualPosition; } }
        public int NumberOfStattions { get { return this.numberOfStations; } }
        public int TotalStopStime => this.totalStopTime;

        public void Run(int times)
        {
            if(times !=0)
            {
                this.actualPosition = this.actualPosition.Add(times, 0);
                this.numberOfStations++;
                this.totalStopTime++;
            }

        }

        public void AdditionalStopAtStation(int minutes)
        {
            if (minutes > 0)
            {
                this.totalStopTime += minutes;
            }
        }
    }
}

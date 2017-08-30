using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class Singleton
    {
        private int number;
        private DateTime datetime;
        private static Singleton instance = new Singleton();

        private Singleton()
        {
            this.number = new Random().Next(0,100);
            this.datetime = DateTime.Now;
        }

        public static Singleton GetInstance()
        {
            return instance;
        }

        public int GetNumber()
        {
            return this.number;
        }

        public DateTime GetDateTime()
        {
            return this.datetime;
        }

    }
}

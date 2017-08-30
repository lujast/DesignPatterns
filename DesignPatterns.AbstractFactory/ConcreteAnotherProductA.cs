﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class ConcreteAnotherProductA : IAnotherProduct
    {
        public void GetProductName()
        {
            Console.WriteLine("I am of type ConcreteanotherProductA");
        }
    }
}

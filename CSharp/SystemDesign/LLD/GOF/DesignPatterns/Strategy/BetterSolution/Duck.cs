using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.BetterSolution
{
    public abstract class Duck 
    {
        public void Swim()
        {
            Console.WriteLine("I swim");
        }

        public abstract void Display();
    }
}

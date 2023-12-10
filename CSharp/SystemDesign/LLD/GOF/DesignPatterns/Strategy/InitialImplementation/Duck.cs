using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.InitialImplementation
{
    public abstract class Duck
    {
        public void Quack()
        {
            Console.WriteLine("I quack");
        }

        public void Swim()
        {
            Console.WriteLine("I swim");
        }

        public abstract void Display();

        // rubber duck does not Fly
        public abstract void Fly();

    }
}

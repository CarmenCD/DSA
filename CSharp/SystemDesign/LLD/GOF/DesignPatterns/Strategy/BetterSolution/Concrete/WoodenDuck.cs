using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.BetterSolution.Concrete
{
    public class WoodenDuck : Duck, IQuack
    {
        public override void Display()
        {
            Console.WriteLine("Wooden duck");
        }

        public void Quack()
        {
            Console.WriteLine("Quack from Wooden duck");
        }
    }
}

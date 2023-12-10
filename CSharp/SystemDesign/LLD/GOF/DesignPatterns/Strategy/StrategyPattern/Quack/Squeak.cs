using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Strategy.StrategyPattern.Quack;

namespace DesignPatterns.Strategy.StrategyPattern.Quak
{
    public class Squeak : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("I can squeak");
        }
    }
}

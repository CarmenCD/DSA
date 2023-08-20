using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.StrategyPattern.Quack
{
    public class QuackNew : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("I am skilled with new quack");
        }
    }
}

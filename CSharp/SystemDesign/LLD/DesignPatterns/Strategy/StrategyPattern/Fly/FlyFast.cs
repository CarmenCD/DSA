using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.StrategyPattern.Fly
{
    public class FlyFast :  IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I am faster when I fly");
        }
    }
}

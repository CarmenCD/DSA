using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.StrategyPattern.Fly
{
    public class FlyNoway : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Noway to fly");
        }
    }
}

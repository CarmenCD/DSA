using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.StrategyPattern.Fly
{
    public class FlyOnlyNight : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Night fly is romantic");
        }
    }
}

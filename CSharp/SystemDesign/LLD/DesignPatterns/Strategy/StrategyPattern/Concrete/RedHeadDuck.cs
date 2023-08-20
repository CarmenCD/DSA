using DesignPatterns.Strategy.BetterSolution;
using IFlyable = DesignPatterns.Strategy.StrategyPattern.Fly.IFlyable;
using IQuack = DesignPatterns.Strategy.StrategyPattern.Quack.IQuack;

namespace DesignPatterns.Strategy.StrategyPattern.Concrete
{
    public class RedHeadDuck : Duck
    {
        public RedHeadDuck(IFlyable flyBehavior, IQuack quackBehavior) : base(flyBehavior, quackBehavior)
        {
        }
        public override void Display()
        {
            Console.WriteLine("RedHead duck");
        }
    }
}

using DesignPatterns.Strategy.StrategyPattern.Fly;
using DesignPatterns.Strategy.StrategyPattern.Quack;

namespace DesignPatterns.Strategy.StrategyPattern.Concrete
{
    public class MallardDuck : Duck
    {
        public MallardDuck(IFlyable flyBehavior, IQuack quackBehavior) : base(flyBehavior, quackBehavior)
        {
        }

        public override void Display()
        {
            Console.WriteLine("Mallard duck");
        }
    }
}

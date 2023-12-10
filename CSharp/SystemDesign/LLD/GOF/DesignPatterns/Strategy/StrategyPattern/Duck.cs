using DesignPatterns.Strategy.StrategyPattern.Fly;
using DesignPatterns.Strategy.StrategyPattern.Quack;
using DesignPatterns.Strategy.StrategyPattern.Quak;

namespace DesignPatterns.Strategy.StrategyPattern
{
    public abstract class Duck
    {
        private readonly IFlyable _flyBehavior;
        private readonly IQuack _quackBehavior;

        protected Duck(IFlyable flyBehavior, IQuack quackBehavior)
        {
            _flyBehavior = flyBehavior;
            _quackBehavior = quackBehavior;
        }
        public void Swim()
        {
        }

        public abstract void Display();

        public void PerformFly()
        {
            _flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            _quackBehavior.Quack();
        }
    }
}

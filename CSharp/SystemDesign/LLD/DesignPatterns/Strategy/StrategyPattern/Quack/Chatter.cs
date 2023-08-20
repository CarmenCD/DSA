namespace DesignPatterns.Strategy.StrategyPattern.Quack
{
    public class Chatter : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Let's start chatting");
        }
    }
}

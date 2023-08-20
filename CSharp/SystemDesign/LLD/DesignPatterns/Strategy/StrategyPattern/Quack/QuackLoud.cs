namespace DesignPatterns.Strategy.StrategyPattern.Quack
{
    public class QuackLoud : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Helllo... Am I quack loud enough?");
        }
    }
}

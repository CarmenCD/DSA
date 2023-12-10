namespace DesignPatterns.Strategy.BetterSolution.Concrete
{
    public class RedHeadDuck : Duck, IFlyable, IQuack
    {
        public override void Display()
        {
            Console.WriteLine("RedHead duck");
        }
        public void Fly()
        {
            Console.WriteLine("I can fly");
        }

        public void Quack()
        {
            Console.WriteLine("Quack from RedHead duck");
        }
    }
}

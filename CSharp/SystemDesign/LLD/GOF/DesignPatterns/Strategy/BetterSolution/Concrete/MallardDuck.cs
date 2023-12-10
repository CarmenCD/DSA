namespace DesignPatterns.Strategy.BetterSolution.Concrete
{
    public class MallardDuck : Duck, IFlyable, IQuack
    {
        public override void Display()
        {
            Console.WriteLine("Mallard duck");
        }

        public void Fly()
        {
            Console.WriteLine("I fly fast");
        }

        public void Quack()
        {
            Console.WriteLine("Quack from Mallard duck");
        }
    }
}

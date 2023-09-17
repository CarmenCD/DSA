namespace DesignPatterns.Strategy.InitialImplementation.Concrete
{
    public class MallardDuck : Duck
    {
        public override void Display()
        { 
            Console.WriteLine("Mallard duck says");
        }

        public override void Fly()
        {
            Console.WriteLine("I can Fly");
        }
    }
}

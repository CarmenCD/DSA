namespace DesignPatterns.Strategy.InitialImplementation.Concrete
{
    public class RedHeadDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("Red head duck says");
        }

        public override void Fly()
        {
            Console.WriteLine("I can Fly");
        }
    }
}

namespace DesignPatterns.Strategy.InitialImplementation.Concrete
{
    public class RubberDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("Rubber duck says:");
        }

        // do nothing since rubber duck cannot fly
        public override void Fly()
        {
            throw new NotImplementedException();
        }
    }
}

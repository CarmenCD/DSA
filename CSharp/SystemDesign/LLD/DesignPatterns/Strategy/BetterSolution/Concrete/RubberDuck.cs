using System;

namespace DesignPatterns.Strategy.BetterSolution.Concrete
{
    public class RubberDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("Rubber duck says: I am a toy");
        }
    }
}

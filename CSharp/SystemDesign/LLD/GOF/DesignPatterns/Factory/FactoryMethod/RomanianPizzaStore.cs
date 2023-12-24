using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.FactoryMethod
{
    public class RomanianPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Console.WriteLine("Creating your concrete pizza");
            Pizza pizza;

            if (string.Equals(type, "cheese"))
            {
                pizza = new RomanianCheesePizza();
            }
            else if (string.Equals(type, "veggie"))
            {
                pizza = new RomanianVeggiePizza();
            }
            else
            {
                throw new NotImplementedException();
            }

            return pizza;
        }
    }
}

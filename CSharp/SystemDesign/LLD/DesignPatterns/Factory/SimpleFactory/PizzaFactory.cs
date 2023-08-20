using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.SimpleFactory
{
    public class PizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            if (string.Equals(type, "cheese"))
                Console.WriteLine("Cheese Pizza is created");
                return new CheesePizza();

            return new Pizza();

        }

    }
}

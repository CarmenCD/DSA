using DesignPatterns.Factory.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesignPatterns.Factory.FactoryMethod
{
    public class IndianPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Console.WriteLine("Creating your concrete pizza");
            Pizza pizza;

            if (string.Equals(type, "cheese"))
            {
                pizza = new IndianCheesePizza();
            }
            else if (string.Equals(type, "veggie"))
            {
                pizza = new IndianVeggiePizza();
            }
            else
            {
                throw new NotImplementedException();
            }

            return pizza;
        }
    }
}

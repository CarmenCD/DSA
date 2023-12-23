using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.FactoryMethod
{
    public class IndianPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            throw new NotImplementedException();
        }
    }
}

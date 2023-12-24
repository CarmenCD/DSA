         using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.FactoryMethod
{
    public abstract class PizzaStore
    {
        // operation method
        public Pizza  OrderPizza(string type)
        {
            Pizza p = CreatePizza(type);
            p.Prepare();
            p.Bake();
            p.Cut();
            p.Box();

            return p;
        }

        //factory method
        protected abstract Pizza CreatePizza(string type);
    }
}

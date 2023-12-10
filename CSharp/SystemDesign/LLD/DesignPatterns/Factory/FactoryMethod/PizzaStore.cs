using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.FactoryMethod
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            Pizza p = CreatePizza(type);
            //p.prepare();
            //base.bake();
            //p.cut();
            //p.box();
            return p;
        }

        //factory method
        protected abstract Pizza CreatePizza(string type);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace DesignPatterns.Factory.SimpleFactory
{
    public class PizzaStore
    {
        private readonly PizzaFactory _factory;
        public PizzaStore(PizzaFactory factory)
        {
            _factory = factory;
        }

        public Pizza OrderPizza(string type)
        {
            return _factory.CreatePizza(type);
        }
        
    }
}

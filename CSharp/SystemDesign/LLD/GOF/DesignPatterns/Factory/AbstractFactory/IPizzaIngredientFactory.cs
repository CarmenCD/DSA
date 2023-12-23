using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.AbstractFactory
{
    public interface IPizzaIngredientFactory
    {
        public string CreateDough();
        public string CreateSauce();
        public string CreateCheese();
        public string[] CreateVeggies();
        public string[] CreateNonVeggies();
    }
}

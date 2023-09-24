using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.AbstractFactory
{
    internal interface IPizzaIngredientFactory
    {
        public string CreateDough();
        public string CreateSauce();
        public string CreateCheese();
        public string[] CreateVeggies();
        public string[] CreateNonVeggies();
    }

    public class INDIngredientFactory : IPizzaIngredientFactory
    {
        public string CreateDough()
        {
            return "Thin Crust Dough";
        }

        public string CreateSauce()
        {
            return "BBQ sauce";
        }

        public string CreateCheese()
        {
            return "Mozzarella cheese";
        }

        public string[] CreateVeggies()
        {
            return new string[] {"tomato", "corn"};
        }

        public string[] CreateNonVeggies()
        {
            return new string[] { "chicken" };
        }
    }

    public class RomanianIngredientFactory : IPizzaIngredientFactory
    {
        public string CreateDough()
        {
            return "Thin Crust Dough";
        }

        public string CreateSauce()
        {
            return "Mustard sauce";
        }

        public string CreateCheese()
        {
            return "Feta cheese";
        }

        public string[] CreateVeggies()
        {
            return new string[] { "tomato", "onion" };
        }

        public string[] CreateNonVeggies()
        {
            return new string[] { "chicken" };
        }
    }
}

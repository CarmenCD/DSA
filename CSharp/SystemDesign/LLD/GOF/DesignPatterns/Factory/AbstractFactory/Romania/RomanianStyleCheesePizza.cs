using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.AbstractFactory.Romania
{
    public class RomanianStyleCheesePizza : Pizza
    {
        private readonly IPizzaIngredientFactory _pizzaIngredientFactory;

        public RomanianStyleCheesePizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            _pizzaIngredientFactory = pizzaIngredientFactory;
            Name = "RomanianStyleCheesePizza";

            Dough = _pizzaIngredientFactory.CreateDough();
            Sauce = _pizzaIngredientFactory.CreateSauce();

            AddTopping(pizzaIngredientFactory.CreateCheese());

            foreach (var veggie in _pizzaIngredientFactory.CreateVeggies())
            {
                AddTopping(veggie);
            }

            foreach (var nonVeggie in _pizzaIngredientFactory.CreateNonVeggies())
            {
                AddTopping(nonVeggie);
            }
        }
    }
}

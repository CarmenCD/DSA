using DesignPatterns.Factory.FactoryMethod;

namespace DesignPatterns.Factory.AbstractFactory.Romania
{
    public class RomanianPizzaStore : PizzaStore
    {
        private readonly IPizzaIngredientFactory _pizzaIngredientFactory;

        public RomanianPizzaStore()
        {
            _pizzaIngredientFactory = new RomanianIngredientFactory();
        }

        protected override Pizza CreatePizza(string type)
        {
            Console.WriteLine("Creating your concrete pizza RO");
            Pizza pizza;

            if (string.Equals(type, "cheese"))
            {
                pizza = new RomanianStyleCheesePizza(_pizzaIngredientFactory);
            }
            else if (string.Equals(type, "veggie"))
            {
                pizza = new RomanianStyleVeggiePizza(_pizzaIngredientFactory);
            }
            else
            {
                throw new NotImplementedException();
            }

            return pizza;

        }
    }
}

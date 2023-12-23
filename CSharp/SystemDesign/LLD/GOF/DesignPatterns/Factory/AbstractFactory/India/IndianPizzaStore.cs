using DesignPatterns.Factory.AbstractFactory.Romania;

namespace DesignPatterns.Factory.AbstractFactory.India
{
    public class IndianPizzaStore : PizzaStore
    {
        private readonly IPizzaIngredientFactory _pizzaIngredientFactory;

        public IndianPizzaStore()
        {
            _pizzaIngredientFactory = new RomanianIngredientFactory();
        }

        protected override Pizza CreatePizza(string type)
        {
            Console.WriteLine("Creating your concrete pizza");
            Pizza pizza;

            if (string.Equals(type, "cheese"))
            {
                pizza = new IndianStyleCheesePizza(_pizzaIngredientFactory);
            }
            else if (string.Equals(type, "veggie"))
            {
                pizza = new IndianStyleVeggiePizza(_pizzaIngredientFactory);
            }
            else
            {
                throw new NotImplementedException();
            }

            return pizza;
        }
    }
}

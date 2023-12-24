using DesignPatterns.Factory.AbstractFactory.Romania;

namespace DesignPatterns.Factory.AbstractFactory.India
{
    public class IndianPizzaStore : PizzaStore
    {
        private readonly IPizzaIngredientFactory _pizzaIngredientFactory;

        public IndianPizzaStore()
        {
            _pizzaIngredientFactory = new IndianIngredientFactory();
        }

        protected override Pizza CreatePizza(string type)
        {
            Console.WriteLine("Creating your concrete pizza IN");
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

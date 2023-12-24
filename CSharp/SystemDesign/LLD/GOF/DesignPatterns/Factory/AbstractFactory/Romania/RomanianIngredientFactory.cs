namespace DesignPatterns.Factory.AbstractFactory.Romania;

public class RomanianIngredientFactory : IPizzaIngredientFactory
{
    public IDough CreateDough()
    {
        return new Classic();
    }

    public ISauce CreateSauce()
    {
        return new Mustard();
    }

    public ICheese CreateCheese()
    {
        return new MozzarellaCheese();
    }

    public string[] CreateVeggies()
    {
        return new string[] { "tomato", "onion" };
    }

    public string[] CreateNonVeggies()
    {
        return new string[] { "pork" };
    }
}
namespace DesignPatterns.Factory.AbstractFactory.Romania;

public class RomanianIngredientFactory : IPizzaIngredientFactory
{
    public string CreateDough()
    {
        return "RO Crust Dough";
    }

    public string CreateSauce()
    {
        return "RO Mustard sauce";
    }

    public string CreateCheese()
    {
        return "RO Feta cheese";
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
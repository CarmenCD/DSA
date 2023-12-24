namespace DesignPatterns.Factory.AbstractFactory.India;

public class IndianIngredientFactory : IPizzaIngredientFactory
{
    public IDough CreateDough()
    {
        return new Thin();
    }

    public ISauce CreateSauce()
    {
        return new Bbq();
    }

    public ICheese CreateCheese()
    {
        return new BlueCheese();
    }

    public string[] CreateVeggies()
    {
        return new string[] { "tomato", "corn" };
    }

    public string[] CreateNonVeggies()
    {
        return new string[] { "chicken" };
    }
}
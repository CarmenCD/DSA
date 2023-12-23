namespace DesignPatterns.Factory.AbstractFactory.India;

public class IndianIngredientFactory : IPizzaIngredientFactory
{
    public string CreateDough()
    {
        return "IN Thin Crust Dough";
    }

    public string CreateSauce()
    {
        return "IN BBQ sauce";
    }

    public string CreateCheese()
    {
        return "IN Mozzarella cheese";
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
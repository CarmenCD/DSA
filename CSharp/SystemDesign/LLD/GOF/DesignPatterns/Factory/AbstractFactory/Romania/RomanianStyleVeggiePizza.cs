namespace DesignPatterns.Factory.AbstractFactory.Romania;

public class RomanianStyleVeggiePizza : Pizza
{
    private readonly IPizzaIngredientFactory _pizzaIngredientFactory;

    public RomanianStyleVeggiePizza(IPizzaIngredientFactory pizzaIngredientFactory)
    {
        _pizzaIngredientFactory = pizzaIngredientFactory;
        Name = "RomanianStyleVeggiePizza";

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
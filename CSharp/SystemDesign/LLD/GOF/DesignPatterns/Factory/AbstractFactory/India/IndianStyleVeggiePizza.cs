namespace DesignPatterns.Factory.AbstractFactory.India;

public class IndianStyleVeggiePizza : Pizza
{
    private readonly IPizzaIngredientFactory _pizzaIngredientFactory;

    public IndianStyleVeggiePizza(IPizzaIngredientFactory pizzaIngredientFactory)
    {
        _pizzaIngredientFactory = pizzaIngredientFactory;
        Name = "IndianStyleVeggiePizza";

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
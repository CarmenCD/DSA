namespace DesignPatterns.Factory.AbstractFactory.India;

public class IndianStyleCheesePizza : Pizza
{
    private readonly IPizzaIngredientFactory _pizzaIngredientFactory;

    public IndianStyleCheesePizza(IPizzaIngredientFactory pizzaIngredientFactory)
    {
        _pizzaIngredientFactory = pizzaIngredientFactory;
        Name = "IndianStyleCheesePizza";

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
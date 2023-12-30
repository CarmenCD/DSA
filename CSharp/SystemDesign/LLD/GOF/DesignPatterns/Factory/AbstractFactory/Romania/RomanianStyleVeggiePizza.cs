namespace DesignPatterns.Factory.AbstractFactory.Romania;

public class RomanianStyleVeggiePizza : Pizza
{
    private readonly IPizzaIngredientFactory _pizzaIngredientFactory;

    public RomanianStyleVeggiePizza(IPizzaIngredientFactory pizzaIngredientFactory)
    {
        _pizzaIngredientFactory = pizzaIngredientFactory;
        Name = "RomanianStyleVeggiePizza";

        var crust = pizzaIngredientFactory.CreateDough();
        Dough = crust.CreateDough();

        var sauce = _pizzaIngredientFactory.CreateSauce();
        Sauce = sauce.CreateSauce();

        var topping = _pizzaIngredientFactory.CreateCheese();
        AddTopping(topping.CreateCheese());

        foreach (var veggie in _pizzaIngredientFactory.CreateVeggies())
        {
            AddTopping(veggie);
        }

        foreach (var nonVeggie in _pizzaIngredientFactory.CreateNonVeggies())
        {
            AddTopping(nonVeggie);
        }

        Console.WriteLine($"Pizza Name: {Name}");
        Console.WriteLine($"Dough RO: {Dough}");
        Console.WriteLine($"Sauce RO: {Sauce}");

        Console.WriteLine($"Pizza Type RO: {topping.CreateCheese()}");
    }
}
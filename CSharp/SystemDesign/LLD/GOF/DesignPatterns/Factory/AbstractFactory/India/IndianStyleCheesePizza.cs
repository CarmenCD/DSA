namespace DesignPatterns.Factory.AbstractFactory.India;

public class IndianStyleCheesePizza : Pizza
{
    private readonly IPizzaIngredientFactory _pizzaIngredientFactory;

    public IndianStyleCheesePizza(IPizzaIngredientFactory pizzaIngredientFactory)
    {
        _pizzaIngredientFactory = pizzaIngredientFactory;
        Name = "IndianStyleCheesePizza";

        var crust = pizzaIngredientFactory.CreateDough();
        Dough = crust.CreateDough();

        var sauce = _pizzaIngredientFactory.CreateSauce();
        Sauce = sauce.CreateSauce();

        var topping = _pizzaIngredientFactory.CreateCheese();
        AddTopping(topping.CreateCheese());

        Console.WriteLine($"Cheese in IN: {topping.CreateCheese()}");


        foreach (var veggie in _pizzaIngredientFactory.CreateVeggies())
        {
            AddTopping(veggie);
        }

        foreach (var nonVeggie in _pizzaIngredientFactory.CreateNonVeggies())
        {
            AddTopping(nonVeggie);
        }

        Console.WriteLine($"Pizza Name: {Name}");
        Console.WriteLine($"Dough IN: {Dough}");
        Console.WriteLine($"Sauce IN: {Sauce}");

        Console.WriteLine($"Pizza Type IN: {topping.CreateCheese()}");
    }

}
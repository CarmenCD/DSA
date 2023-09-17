// See https://aka.ms/new-console-template for more information

using DesignPatterns.Factory.SimpleFactory;

var factory = new PizzaFactory();

var pizzaStore = new PizzaStore(factory);
pizzaStore.OrderPizza("cheese");

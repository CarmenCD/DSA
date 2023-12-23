// See https://aka.ms/new-console-template for more information

using DesignPatterns.Factory.FactoryMethod;
using DesignPatterns.Factory.SimpleFactory;
using PizzaStore = DesignPatterns.Factory.SimpleFactory.PizzaStore;

/* initial implementation */
Console.WriteLine("**********************************************************");
Console.WriteLine("* Simple factory:                                        * \n" +
                  "*    1. pull out the CreatePizza into PizzaFactory class * ");
Console.WriteLine("**********************************************************");

var factory = new PizzaFactory();

var pizzaStore = new PizzaStore(factory);
pizzaStore.OrderPizza("cheese");

Console.WriteLine("**********************************************************************************");
Console.WriteLine("* Factory Method:                                                                * \n" +
                  "*    1. Object base class (Pizza)                                                * \n" +
                  "*    2. Concrete implementation (IS-A relation)                                  * \n" +
                  "             - cheese pizza, veggie pizza, etc                                   * \n" +
                  "     3. Creator (Pizza Store)                                                    * \n" +
                  "             - an operation (optional) (OrderPizza)                              * \n" +
                  "             - factory method (abstract) (Create Pizza)                          * \n" +
                  "     4. Concrete Creator (HAS-A) concrete implementation                         * \n" +
                  "             - will implement factory method                                     * \n" +
                  "             - when a new style will appear a new implementation will be done    * \n");
Console.WriteLine("**********************************************************************************");

var pizzaStoreRomanian = new RomanianPizzaStore();
var p =pizzaStoreRomanian.OrderPizza("veggie");
Console.WriteLine($"Pizza created: {p.Name}");
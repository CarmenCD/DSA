// See https://aka.ms/new-console-template for more information

using DesignPatterns.Strategy.BetterSolution;
using DesignPatterns.Strategy.InitialImplementation.Concrete;
using DesignPatterns.Strategy.StrategyPattern.Fly;
using DesignPatterns.Strategy.StrategyPattern.Quack;
using IFlyable = DesignPatterns.Strategy.StrategyPattern.Fly.IFlyable;
using IQuack = DesignPatterns.Strategy.StrategyPattern.Quack.IQuack;
using Second = DesignPatterns.Strategy.BetterSolution.Concrete;
using Strategy = DesignPatterns.Strategy.StrategyPattern;

/* initial implementation */
Console.WriteLine("******************************************************");
Console.WriteLine("* Initial implementation:                            * \n" +
                  "*    1. A superclass and                             * \n" +
                  "*    2. subclasses that implements display and fly   * ");
Console.WriteLine("******************************************************");
var mallard = new MallardDuck();
mallard.Display();
mallard.Fly();
mallard.Quack();
mallard.Swim();

var redHead = new RedHeadDuck();
redHead.Display();
redHead.Fly();
redHead.Quack();
redHead.Swim();

var rubber = new RubberDuck();
rubber.Display();
rubber.Swim();
Console.WriteLine("Rubble duck also has Fly method but will throw not implemented exception");
// tis brakes Liskov substitute principle
// rubber.Fly();
Console.WriteLine("Does Rubble duck says:");
rubber.Quack();
Console.WriteLine("Is that true?");

Console.WriteLine("***********************************************************");
Console.WriteLine("* Better implementation - avoid not implemented methods   *");
Console.WriteLine("*    1. Create interfaces for particular behaviour.       * \n" +
                  "*    2. Keep common behaviour in superclass               * \n" +
                  "*    3. Only needed subclasses implements interfaces      *");
Console.WriteLine("***********************************************************");

var mallard2 = new Second.MallardDuck();
mallard2.Display();
mallard2.Fly();
mallard2.Quack();
mallard2.Swim();

var redHead2 = new Second.RedHeadDuck();
redHead2.Display();
redHead2.Fly();
redHead2.Quack();
redHead2.Swim();

var rubber2 = new Second.RubberDuck();
rubber2.Display();
Console.WriteLine("Rubble duck Does not implement Fly");
// rubber2.Fly();
Console.WriteLine("Rubble duck Does not implement Quack");
// rubber2.Quack()
rubber2.Swim();

// Duck d = new Second.MallardDuck();
// var wd = new Second.WoodenDuck();

// d = wd;
// cannot do that anyway
// d.Fly();

Console.WriteLine("***********************************************************");
Console.WriteLine("* Strategy pattern - avoid not implemented methods   *");
Console.WriteLine("*    1. Create interfaces for particular behaviour.       * \n" +
                  "*    2. Keep common behaviour in superclass               * \n" +
                  "*    3. Only needed subclasses implements interfaces      *");
Console.WriteLine("***********************************************************");

IFlyable fly = new FlyWithWings();
IQuack quack = new Chatter();
Strategy.Duck duck = new Strategy.Concrete.MallardDuck(fly, quack);
duck.Display();
duck.Swim();
duck.PerformQuack();
duck.PerformFly();


Console.WriteLine("***********************************************************");
Console.WriteLine("* New Requirements                                        *");
Console.WriteLine("*    1. A new type of Quack must be implemented.          * \n" +
                  "*    2. A new type of duck must be implemented            * \n" +
                  "*    this will not touch the current implementation       * \n" +
                  "Only in case of new Interfaces (IMigrate) the Duck must be changed");
Console.WriteLine("***********************************************************");

Console.WriteLine("\n* New Quack * ");
// New Quack
IFlyable flyCurrent = new FlyWithWings();
IQuack quackNew = new QuackNew();
Strategy.Duck duckMallard = new Strategy.Concrete.MallardDuck(flyCurrent, quackNew);
duckMallard.Display();
duckMallard.Swim();
duckMallard.PerformQuack();
duckMallard.PerformFly();

Console.WriteLine("\n* New duck *");
Strategy.Duck woodenDuck = new Strategy.Concrete.WoodenDuck(flyCurrent, quackNew);
woodenDuck.Display();
woodenDuck.Swim();
woodenDuck.PerformQuack();
woodenDuck.PerformFly();
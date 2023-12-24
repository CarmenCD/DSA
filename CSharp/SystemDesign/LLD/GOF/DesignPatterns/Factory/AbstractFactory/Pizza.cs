using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.AbstractFactory
{
    public class Pizza
    {
        public string? Name { get; protected set; }
        public string? Dough { get; protected set; }
        public string? Sauce { get; protected set; }

        private readonly List<string> _toppings = new();
        public static void Prepare()
        {
            Console.WriteLine("Prepare pizza");
        }
        public static void Bake()
        {
            Console.WriteLine("Bake pizza");
        }
        public static void Cut()
        {
            Console.WriteLine("Cut pizza");
        }
        public static void Box()
        {
            Console.WriteLine("Box the pizza");
        }

        public Pizza AddTopping(string topping)
        {
            _toppings.Add(topping);
            return this;
        }
    }
}

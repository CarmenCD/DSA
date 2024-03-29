﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.FactoryMethod
{
    public class Pizza
    {
        public string? Name { get; protected set; }
        public string? Dough { get; protected set; }
        public string? Sauce { get; protected set; }

        private readonly List<string> _toppings = new();

        public void Prepare()
        {
            Console.WriteLine("Prepare pizza");
        }
        public void Bake()
        {
            Console.WriteLine("Bake pizza");
        }
        public void Cut()
        {
            Console.WriteLine("Cut pizza");
        }
        public void Box()
        {
            Console.WriteLine("Box the pizza");
        }

        public Pizza AddTopping(string topping)
        {
            this._toppings.Add(topping);
            return this;
        }

    }
}

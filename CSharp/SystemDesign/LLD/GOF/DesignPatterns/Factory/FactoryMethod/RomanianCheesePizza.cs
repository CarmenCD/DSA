using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace DesignPatterns.Factory.FactoryMethod
{
    public class RomanianCheesePizza : Pizza
    {
        public RomanianCheesePizza()
        {
            Name = "RO Cheese Pizza";
            Dough = "Classic crust";
            Sauce = "BBQ";
            AddTopping("tomato")
                .AddTopping("cheese")
                .AddTopping("tomato")
                .AddTopping("onion")
                .AddTopping("pork");
        }
    }
}

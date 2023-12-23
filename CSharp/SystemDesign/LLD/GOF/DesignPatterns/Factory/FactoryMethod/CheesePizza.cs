using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace DesignPatterns.Factory.FactoryMethod
{
    public class CheesePizza : Pizza
    {
        public CheesePizza()
        {
            Name = "Cheese Pizza";
            Dough = "Thin crust";
            Sauce = "BBQ";
            AddTopping("tomato")
                .AddTopping("cheese")
                .AddTopping("baby corn")
                .AddTopping("onion")
                .AddTopping("capsicum");

        }
    }
}

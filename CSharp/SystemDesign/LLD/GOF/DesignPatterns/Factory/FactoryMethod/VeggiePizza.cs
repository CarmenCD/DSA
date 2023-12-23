using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace DesignPatterns.Factory.FactoryMethod
{
    public class VeggiePizza : Pizza
    {
        public VeggiePizza()
        {
            Name = "Veggie Pizza";
            Dough = "Thin crust";
            Sauce = "BBQ";
            AddTopping("tomato")
                .AddTopping("baby corn")
                .AddTopping("onion");

        }
    }
}

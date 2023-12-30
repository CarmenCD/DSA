using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.FactoryMethod
{
    internal class IndianVeggiePizza :Pizza
    {
        public IndianVeggiePizza()
        {
            Name = "IN Veggie Pizza";
            Dough = "Thin crust";
            Sauce = "BBQ";
            AddTopping("tomato")
                .AddTopping("cheese")
                .AddTopping("baby corn")
                .AddTopping("capsicum");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.FactoryMethod
{
    public class IndianCheesePizza : Pizza
    {
        public IndianCheesePizza()
        {
            Name = "IN Cheese Pizza";
            Dough = "Thin crust";
            Sauce = "BBQ";
            AddTopping("tomato")
                .AddTopping("cheese")
                .AddTopping("baby corn")
                .AddTopping("chicken")
                .AddTopping("capsicum");
        }
    }
}

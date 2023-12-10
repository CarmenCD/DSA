using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.AbstractFactory
{
    public abstract class Pizza
    {
        public string Dough { get; set; }
        public string Cheese { get; set; }
        public string Sauce { get; set; }
    }
}

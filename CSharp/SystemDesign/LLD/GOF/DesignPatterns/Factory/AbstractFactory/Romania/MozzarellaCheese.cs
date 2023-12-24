using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.AbstractFactory.Romania
{
    public class MozzarellaCheese : ICheese
    {
        public string CreateCheese()
        {
            return "mozzarella cheese";
        }
    }
}

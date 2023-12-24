using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.AbstractFactory.India
{
    public class BlueCheese : ICheese
    {
        public string CreateCheese()
        {
            return "blue cheese";
        }
    }
}

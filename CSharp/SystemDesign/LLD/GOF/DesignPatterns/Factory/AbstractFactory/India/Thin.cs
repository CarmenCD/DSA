using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.AbstractFactory.India
{
    internal class Thin : IDough
    {
        public string CreateDough()
        {
            return "Thin Crust";
        }
    }
}

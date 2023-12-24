using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.AbstractFactory.Romania
{
    internal class Classic : IDough
    {
        public string CreateDough()
        {
            return "classic crust";
        }
    }
}

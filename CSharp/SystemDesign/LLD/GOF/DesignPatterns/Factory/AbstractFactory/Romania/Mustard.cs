using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.AbstractFactory.Romania
{
    public class Mustard : ISauce
    {
        public string CreateSauce()
        {
            return "Mustard sauce";
        }
    }
}

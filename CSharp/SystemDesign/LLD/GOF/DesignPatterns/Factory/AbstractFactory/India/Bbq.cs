using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.AbstractFactory.India
{
    public class Bbq : ISauce
    {
        public string CreateSauce()
        {
            return "BBQ sauce";
        }
    }
}

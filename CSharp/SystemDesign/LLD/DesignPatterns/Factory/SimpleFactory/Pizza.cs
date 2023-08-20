using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.SimpleFactory
{
    public class Pizza
    {
        public void Prepare()
        {
            Console.WriteLine("Prepare pizza");
        }
        public void Bake()
        {
            Console.WriteLine("Bake pizza");
        }
        public void Cut()
        {
            Console.WriteLine("Cut pizza");
        }
        public void Box()
        {
            Console.WriteLine("Box the pizza");
        }

    }
}

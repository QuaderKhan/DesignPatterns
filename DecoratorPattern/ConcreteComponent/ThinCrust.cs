using DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteComponent
{
    public class ThinCrust : BasePizza
    {
        public override string name()
        {
            return "Thin Crust";
        }

        public override double price()
        {
            return 50;
        }
    }
}

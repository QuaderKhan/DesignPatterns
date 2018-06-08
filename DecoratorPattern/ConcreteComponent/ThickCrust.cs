using DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteComponent
{
    public class ThickCrust : BasePizza
    {
        public override string name()
        {
            return "Thick Crust";
        }

        public override double price()
        {
            return 40;
        }
    }
}

using DecoratorPattern.Component;
using DecoratorPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteDecorator
{
    public class Soya : Toppings
    {
        private string _name = "Soya";
        private double _price = 30;

        public Soya(BasePizza basepizza):base(basepizza)
        {

        }
        public override string name()
        {
            return BasePizza.name() + _name;
        }

        public override double price()
        {
            return BasePizza.price() + _price;
        }
    }
}

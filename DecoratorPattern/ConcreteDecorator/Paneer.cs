using DecoratorPattern.Component;
using DecoratorPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteDecorator
{
    public class Paneer : Toppings
    {
        private string _name = "Paneer";
        private double _price = 35;

        public Paneer(BasePizza basepizza)
            : base(basepizza)
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

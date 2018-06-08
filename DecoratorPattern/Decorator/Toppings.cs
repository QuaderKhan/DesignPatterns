using DecoratorPattern.Component;
using System;

namespace DecoratorPattern.Decorator
{
    public abstract class Toppings : BasePizza
    {
        protected BasePizza BasePizza { get; set; }

        protected Toppings(BasePizza _basePizza)
        {
            BasePizza = _basePizza;
        }

        public override string name()
        {
            throw new NotImplementedException();
        }

        public override double price()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class AbstractClass
    {
        public abstract void display();
        public abstract void display(string s);
        public virtual void virtualMethod()
        {
            Console.WriteLine("This is virtual method of abstract class");
        }
    }

    public class UseAbstract : AbstractClass
    {

        public override void display()
        {
            Console.WriteLine("This is overriden void disply method");
        }

        public override void display(string s)
        {
            Console.WriteLine("This is overriden disply method");
        }

        public override void virtualMethod()
        {
            Console.WriteLine("This is overriden virtual method");
        }

    }

    public class b
    {
        UseAbstract abs;
        public void method()
        {
            abs = new UseAbstract();
            abs.display();

            abs.display("tell");


            abs.display(s: "tell");

            abs.virtualMethod();
        }
    }
}

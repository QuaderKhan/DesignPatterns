using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public  class Class1
    {

        public void add(int a, int b)
        {

        }
    }

    public class Class2 : Class1
    {
        public void sub()
        {

        }

        public new void add(int a, int b, int c)
        {

        }
    }

    public class Class3
    {
        Class1 cls2 = new Class1();

        public void test()
        {
            cls2.add(1, 2);
            
        }

    }

    
}

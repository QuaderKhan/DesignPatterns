using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Outer
    {

        class inner
        {
            internal int use;
            public void access()
            {

            }
        }

        public int useInner()
        {

            inner i = new inner();

            i.access();

            return i.use;



        }
    }

    class Outer2
    {
        public void test()
        {
            Outer o1 = new Outer();
            int a = o1.useInner();

        }


    }


}

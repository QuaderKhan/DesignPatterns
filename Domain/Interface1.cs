using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface Interface1
    {
        
        void foo();


    }

    public interface Interface2
    {
        void foo();
    }

  
    

    class a : Interface1,Interface2
    {
        
        public void foo()
        {
            throw new NotImplementedException();
        }
    }
}

namespace second
{

    partial interface Interface3
    {
        void first();
    }

    class b :Interface3
    {
        object o;

        public void first()
        {
            throw new NotImplementedException();
        }
    }

}

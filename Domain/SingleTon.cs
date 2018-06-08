using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public sealed class SingleTon
    {
        private static object objLock = new object();
        static SingleTon objSingle;

        private SingleTon()
        {

        }

        public static SingleTon GetInstance()
        {
            lock (objLock)
            {
                if (objSingle != null)
                {
                    return objSingle;
                }
                else
                {
                    return new SingleTon();
                }
            }
        }
    }

    class UseSingleTon
    {
        SingleTon s = SingleTon.GetInstance();
        
    }
}

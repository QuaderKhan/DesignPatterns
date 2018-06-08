using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public static class ExtensionMethodDemo
    {
        public static int IncrementByTwo(this int x)
        {
            return x + 2;
        }

        public static Class1 DomyWork(this Class1 x)
        {

            return new Class1();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
     class KeyByVendor : IKey
    {
        public string GetKey()
        {
            return "Key from Vendor";
        }
    }
}

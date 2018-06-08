using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class KeyFactory
    {
        static public IKey GetKeyByType(KeyTypes keyType)
        {
            switch (keyType)
            {
                case KeyTypes.GeneratedKey:
                    return new KeyByGen();
                    
                case KeyTypes.StockedKey:
                    return new KeyByStock();

                case KeyTypes.VendorKey:
                    return new KeyByVendor();
                default:
                    return null;
                    
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyWCFServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SessionHandlingService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SessionHandlingService.svc or SessionHandlingService.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class SessionHandlingService : ISessionHandlingService
    {
        int number;
        public int ReturnNextNumber()
        {
            return number++;
        }
    }
}

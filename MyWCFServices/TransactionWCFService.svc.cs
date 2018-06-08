using MyWCFServices.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;



namespace MyWCFServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TransactionWCFService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TransactionWCFService.svc or TransactionWCFService.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(TransactionIsolationLevel = System.Transactions.IsolationLevel.Serializable)]
    public class TransactionWCFService : ITransactionContract
    {

        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        public int AddRegion(Region region)
        {
            DataManager mgr = new DataManager();
            return mgr.SaveRegion(region);
        }

        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        public int AddTeritory(Territory territory)
        {
            DataManager mgr = new DataManager();
            return mgr.SaveTerritory(territory);
        }
    }
}

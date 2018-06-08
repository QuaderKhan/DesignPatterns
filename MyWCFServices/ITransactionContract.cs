using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MyWCFServices
{
    [ServiceContract]
    public interface ITransactionContract
    {
        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        int AddRegion(Region region);

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Mandatory)]
        int AddTeritory(Territory territory);

    }

}

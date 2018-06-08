using MyWCFServices.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyWCFServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DataService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select DataService.svc or DataService.svc.cs at the Solution Explorer and start debugging.
    public class DataService : IDataService
    {
        DataManager bll;

        public Customer GetCustomer(string CustomerId)
        {
            bll = new DataManager();
            return bll.GetCustomerByID(CustomerId);
        }


        public List<Customer> GetAllCustomers()
        {
            bll = new DataManager();
            return bll.GetCustomres();
        }

        public int AddCustomer(Customer customer)
        {
            bll = new DataManager();
            return bll.AddCustomer(customer);
        }

        public int UpdateCustomer(Customer customer)
        {
            bll = new DataManager();
            return bll.UpdateCustomer(customer);
        }
    }

    public class TransactionService : ITransactionContract
    {

        public int AddRegion(Region region)
        {
            throw new NotImplementedException();
        }

        public int AddTeritory(Territory territory)
        {
            throw new NotImplementedException();
        }
    }

}

using MyWCFServices.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWCFServices.Manager
{
    public class DataManager
    {
        DataAccessLayer dal;
        public Customer GetCustomerByID(string id)
        {
            dal = new DataAccessLayer();
            return dal.GetCustomer(id);
        }

        public List<Customer> GetCustomres()
        {
            dal = new DataAccessLayer();
            return dal.GetAllCustomers();
        }

        public int AddCustomer(Customer customer)
        {
            dal = new DataAccessLayer();
            return dal.AddCustomer(customer);
        }

        public int UpdateCustomer(Customer customer)
        {
            dal = new DataAccessLayer();
            return dal.UpdateCustomer(customer);
        }

        public int SaveRegion(Region region)
        {
            dal = new DataAccessLayer();
            return dal.SaveRegion(region);

        }

        public int SaveTerritory(Territory territory)
        {
            dal = new DataAccessLayer();
            return dal.SaveTerritory(territory);
        }
    }
}
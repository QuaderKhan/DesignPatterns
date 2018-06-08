using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyWCFServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDataService" in both code and config file together.
    [ServiceContract]
    public interface IDataService
    {
        [OperationContract]
        Customer GetCustomer(string CustomerId);

        [OperationContract]
        List<Customer> GetAllCustomers();

        [OperationContract]
        int AddCustomer(Customer customer);

        [OperationContract]
        int UpdateCustomer(Customer customer);

    }

  

    [DataContract]
    public class Customer
    {
        [DataMember]
        public string CustomerID { get; set; }

        [DataMember]
        public string CompanyName { get; set; }

        [DataMember]
        public string ContactName { get; set; }

        [DataMember]
        public string ContactTitle { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string Region { get; set; }

        [DataMember]
        public string PostalCode { get; set; }

        [DataMember]
        public string Country { get; set; }

        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        public string Fax { get; set; }
    }

    [DataContract]
    public class Region
    {
        [DataMember]
        public int RegionID { get; set; }

        [DataMember]
        public string RegionDescription { get; set; }
    }

    [DataContract]
    public class Territory
    {
        [DataMember]
        public string TerritoryID { get; set; }

        [DataMember]
        public string TerritoryDescription { get; set; }

        [DataMember]
        public int RegionID { get; set; }
    }
}

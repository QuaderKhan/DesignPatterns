using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace MyWCFServices.DAL
{
    public class DataAccessLayer
    {

        public Customer GetCustomer(string id)
        {
            NorthwindEntities context = new NorthwindEntities();
            var customerEntity = (from c
                                 in context.CustomerEntities
                                  where c.CustomerID == id
                                  select c).FirstOrDefault();

            if (customerEntity != null)
            {
                return TranslateCustomerEntityToCustomer(customerEntity);
            }
            else
                throw new Exception("Invalid Customer ID");

        }


        private Customer TranslateCustomerEntityToCustomer(
                CustomerEntity customerEntity)
        {
            Customer cust = new Customer()
            {
                CustomerID = customerEntity.CustomerID,
                ContactName = customerEntity.ContactName,
                CompanyName = customerEntity.CompanyName,
                Address = customerEntity.Address,
                City = customerEntity.City,
                ContactTitle = customerEntity.ContactTitle,
                Country = customerEntity.Country,
                Fax = customerEntity.Fax,
                Phone = customerEntity.Phone,
                PostalCode = customerEntity.PostalCode,
                Region = customerEntity.Region
            };

            return cust;
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            NorthwindEntities context = new NorthwindEntities();

            customers = (from item in context.CustomerEntities
                         select new Customer
                         {
                             CustomerID = item.CustomerID,
                             ContactName = item.ContactName,
                             ContactTitle = item.ContactTitle,
                             CompanyName = item.CompanyName,
                             Address = item.Address,
                             City = item.City,
                             Country = item.Country,
                             Region = item.Region,
                             PostalCode = item.PostalCode,
                             Phone = item.Phone,
                             Fax = item.Fax

                         }).ToList<Customer>();

            /*
            var query = context.CustomerEntities.ToList();

            foreach (var item in query)
            {
                customers.Add(new Customer
                                {
                                    CustomerID = item.CustomerID,
                                    ContactName = item.ContactName,
                                    ContactTitle = item.ContactTitle,
                                    CompanyName = item.CompanyName,
                                    Address = item.Address,
                                    City = item.City,
                                    Country = item.Country,
                                    Region = item.Region,
                                    PostalCode = item.PostalCode,
                                    Phone = item.Phone,
                                    Fax = item.Fax

                                }
                              );
            }
             * */

            return customers;

        }

        public int AddCustomer(Customer customer)
        {
            NorthwindEntities context = new NorthwindEntities();

            CustomerEntity cust = new CustomerEntity
            {
                CustomerID = customer.CustomerID,
                ContactName = customer.ContactName,
                ContactTitle = customer.ContactTitle,
                CompanyName = customer.CompanyName,
                Address = customer.Address,
                City = customer.City,
                Country = customer.Country,
                Region = customer.Region,
                PostalCode = customer.PostalCode,
                Phone = customer.Phone,
                Fax = customer.Fax

            };

            context.CustomerEntities.Add(cust);
            return context.SaveChanges();
        }

        public int UpdateCustomer(Customer customer)
        {
            NorthwindEntities context = new NorthwindEntities();
            CustomerEntity cust = (CustomerEntity)(from c in context.CustomerEntities
                                                   where c.CustomerID == customer.CustomerID
                                                   select c).FirstOrDefault();

            cust.Address = customer.Address;
            cust.ContactName = customer.ContactName;
            cust.ContactTitle = customer.ContactTitle;
            cust.CompanyName = customer.CompanyName;
            cust.Address = customer.Address;
            cust.City = customer.City;
            cust.Country = customer.Country;
            cust.Region = customer.Region;
            cust.PostalCode = customer.PostalCode;
            cust.Phone = customer.Phone;
            cust.Fax = customer.Fax;

            return context.SaveChanges();
        }


        public int SaveRegion(Region region)
        {
            NorthwindEntities context = new NorthwindEntities();

            RegionEntity r = new RegionEntity()
            {
                RegionID = region.RegionID,
                RegionDescription = region.RegionDescription
            };

            context.RegionEntities.Add(r);
            return context.SaveChanges();
        }



        public int SaveTerritory(Territory territory)
        {
            NorthwindEntities context = new NorthwindEntities();

            TerritoryEntity t = new TerritoryEntity
            {
                TerritoryID = territory.TerritoryID,
                RegionID = territory.RegionID,
                TerritoryDescription = territory.TerritoryDescription
            };

            context.TerritoryEntities.Add(t);
            return context.SaveChanges();
        }

    }
}
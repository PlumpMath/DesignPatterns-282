using System;
using System.Collections.Generic;

namespace DesignPatterns.Adapter_CustomerExample
{
    public class CustomerAdapter : ICustomerList
    {
        List<Customer> Customers = new List<Customer>();

        public void AddCustomer(CustomerDTO customer)
        {
            Customers.Add(new Customer()
            {
                CustomerID = customer.ID,
                Address = customer.Address,
                City = customer.City,
                Name = customer.FirstName + " " + customer.LastName,
                State = customer.State,
                Zip = customer.PostalCode
            });
        }

        public List<Customer> GetCustomers()
        {
            return Customers;
        }
    }
}

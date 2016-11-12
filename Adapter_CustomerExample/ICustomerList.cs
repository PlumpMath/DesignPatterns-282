using System.Collections.Generic;

namespace DesignPatterns.Adapter_CustomerExample
{
    public interface ICustomerList
    {
        List<Customer> GetCustomers();

        void AddCustomer(CustomerDTO customer);
    }
}

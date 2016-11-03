using System.Collections;
using System.Collections.Generic;
using ScratchAPI.Models;

namespace ScratchAPI.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public CustomerRepository()
        {
            this.customers = new List<Customer>();
            this.customers.Add(new Customer { Firstname = "Blair", Lastname = "Davidson"});
        }

        public IEnumerable<Customer> GetAll()
        {
            return customers;
        }

        private List<Customer> customers;
    }
}
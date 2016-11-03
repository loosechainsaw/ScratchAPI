using System.Collections.Generic;
using ScratchAPI.Models;

namespace ScratchAPI.Repositories
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAll();
    }
}
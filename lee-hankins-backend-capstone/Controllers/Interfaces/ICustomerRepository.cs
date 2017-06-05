using lee_hankins_backend_capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lee_hankins_backend_capstone.Controllers.Interfaces
{
    public interface ICustomerRepository
    {
        void Save(Customer newCustomer);
        IEnumerable<Customer> GetAll();
    }
}

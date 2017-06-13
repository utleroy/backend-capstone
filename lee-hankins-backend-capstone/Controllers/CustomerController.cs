using lee_hankins_backend_capstone.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace lee_hankins_backend_capstone.Controllers
{
    public class CustomerController : ApiController
    {
        private CustomerRepository _customerRepository;

        public CustomerController(CustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        // GET: api/Customer
        public IEnumerable<Customer> Get()
        {
            return _customerRepository.GetAll();
        }

        // GET: api/Customer/
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Customer
        public void Post(Customer newCustomer)
        {
            _customerRepository.Save(newCustomer);
        }

        // PUT: api/Customer/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Customer/5
        public void Delete(int id)
        {
            _customerRepository.Delete(id); 
        }
    }
}

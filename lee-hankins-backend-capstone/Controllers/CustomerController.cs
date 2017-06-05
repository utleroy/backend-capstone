using lee_hankins_backend_capstone.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace lee_hankins_backend_capstone.Controllers
{
    public class CustomerController : ApiController
    {
        // GET: api/Customer
        public IEnumerable<Customer> Get()
        {
            var customerRepository = new CustomerRepository();
            return customerRepository.Retrieve();
        }

        // GET: api/Customer/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Customer
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Customer/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Customer/5
        public void Delete(int id)
        {
        }
    }
}

using lee_hankins_backend_capstone.Controllers.Interfaces;
using lee_hankins_backend_capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace lee_hankins_backend_capstone.Controllers
{
    [RoutePrefix("api/customer")]
    public class CustomerController : ApiController
    {
        readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpPost, Route]
        public HttpResponseMessage RegisterCustomer(Customer customer)
        {
            if (string.IsNullOrWhiteSpace(customer.UserName))
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Invalid Username");
            }

            _customerRepository.Save(customer);

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpGet, Route]
        public HttpResponseMessage GetAll()
        {
            var customers = _customerRepository.GetAll();

            return Request.CreateResponse(HttpStatusCode.OK, customers);
        }
    }
}

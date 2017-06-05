using lee_hankins_backend_capstone.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Hosting;
using System.Web.Http;

namespace lee_hankins_backend_capstone.Controllers
{
    //[RoutePrefix("api/Customer")]
    public class CustomerRepository : ApiController
    {
        internal Customer Create()
        {
            Customer customer = new Customer()
            {
                DateActive = DateTime.Now
            };
            return customer;
        }

        internal List<Customer> Retrieve()
        {
            var jsonPath = HostingEnvironment.MapPath(@"~/app/app_data/seed-data.json");

            var json = System.IO.File.ReadAllText(jsonPath);

            var customerList = JsonConvert.DeserializeObject<List<Customer>>(json);

            return customerList;
        }

        //saves newly created customer
        internal Customer Save(Customer customer)
        {
            var customerList = this.Retrieve();

            var newId = customerList.Max(p => p.CustomerId);

            customer.CustomerId = newId + 1;

            customerList.Add(customer);

            WriteData(customerList);

            return customer;
        }

        //updates existing customer
        internal Customer Save(int id, Customer customer)
        {
            var customerList = this.Retrieve();

            var customerIndex = customerList.FindIndex(p => p.CustomerId == customer.CustomerId);
            if (customerIndex > 0)
            {
                customerList[customerIndex] = customer;
            }
            else
            {
                return null;
            }
            WriteData(customerList);
            return customer;
        }

        private bool WriteData(List<Customer> customerList)
        {
            var jsonPath = HostingEnvironment.MapPath(@"~/app/app_data/seed-data.json");

            var json = JsonConvert.SerializeObject(customerList, Formatting.Indented);
            System.IO.File.WriteAllText(jsonPath, json);

            return true;
        }

        
        

        //readonly ICustomerRepository _customerRepository;

        //public CustomerRepository(ICustomerRepository customerRepository)
        //{
        //    _customerRepository = customerRepository;
        //}

        //[HttpPost, Route]
        //public HttpResponseMessage RegisterCustomer(Customer customer)
        //{
        //    if (string.IsNullOrWhiteSpace(customer.UserName))
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Invalid Username");
        //    }

        //    _customerRepository.Save(customer);

        //    return Request.CreateResponse(HttpStatusCode.OK);
        //}

        //[HttpGet, Route]
        //public HttpResponseMessage GetAll()
        //{
        //    var customers = _customerRepository.GetAll();

        //    return Request.CreateResponse(HttpStatusCode.OK, customers);
        //}
    }
}

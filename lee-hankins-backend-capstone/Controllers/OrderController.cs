using lee_hankins_backend_capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace lee_hankins_backend_capstone.Controllers
{
    public class OrderController : ApiController
    {

        private OrderRepository _orderRepository;
        private CustomerRepository _customerRepository;

        public OrderController(OrderRepository orderRepository, CustomerRepository customerRepository)
        {
            _orderRepository = orderRepository;
            _customerRepository = customerRepository;
        }
        // GET: api/Order
        public IEnumerable<Order> Get()
        {
            return _orderRepository.GetAll();
        }

        // GET: api/Order/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Order
        public Order Post([FromBody]int customerId)
        {
            var newOrder = new Order
            {
                Customer = _customerRepository.Get(customerId)
            };

            _orderRepository.Save(newOrder);

            return newOrder;
        }

        // PUT: api/Order/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Order/5
        public void Delete(int id)
        {
        }
    }
}

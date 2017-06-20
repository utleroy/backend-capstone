using lee_hankins_backend_capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace lee_hankins_backend_capstone.Controllers
{
    public class LineItemController : ApiController
    {
        private LineItemRepository _lineItemRepository;
        private OrderRepository _orderRepository;

        public LineItemController(LineItemRepository lineItemRepository, OrderRepository orderRepository)
        {
            _lineItemRepository = lineItemRepository;
            _orderRepository = orderRepository;
        }
        // GET: api/LineItem
        public IEnumerable<LineItem> Get()
        {
            return _lineItemRepository.GetAll();

        }

        // GET: api/LineItem/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/LineItem
        public void Post(AddLineItemViewModel lineItem)
        {
            var newLineItem = new LineItem
            {
                imprintPrice = lineItem.imprintPrice,
                imprintTotal = lineItem.imprintTotal,
                lineTotal = lineItem.lineTotal,
                product = lineItem.product,
                quantity = lineItem.quantity,
                shirtPrice = lineItem.shirtPrice,
                Order = _orderRepository.Get(lineItem.orderId)
            };

            _lineItemRepository.Save(newLineItem);
        }

        // PUT: api/LineItem/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/LineItem/5
        public void Delete(int id)
        {
            _lineItemRepository.Delete(id);
        }
    }
}

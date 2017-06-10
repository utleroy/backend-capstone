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
        public LineItemController(LineItemRepository lineItemRepository)
        {
            _lineItemRepository = lineItemRepository;
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
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/LineItem/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/LineItem/5
        public void Delete(int id)
        {
        }
    }
}

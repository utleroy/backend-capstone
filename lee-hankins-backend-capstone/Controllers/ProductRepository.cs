using System;
using System.Collections.Generic;
using System.Web.Http;
using lee_hankins_backend_capstone.Models;

namespace lee_hankins_backend_capstone.Controllers
{
    internal class ProductRepository : ApiController
    {
        public ProductRepository()
        {
        }

        internal static IEnumerable<Product> Retrieve()
        {
            throw new NotImplementedException();
        }
    }
}
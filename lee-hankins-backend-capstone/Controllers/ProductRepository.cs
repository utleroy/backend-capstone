using System;
using System.Collections.Generic;
using System.Web.Http;
using lee_hankins_backend_capstone.Models;
using RestSharp;
using System.Configuration;
using RestSharp.Authenticators;

namespace lee_hankins_backend_capstone.Controllers
{

    [RoutePrefix("api/product")]
    public class ProductRepository
    {

        readonly ApplicationDbContext _context;
        private IRestClient _restClient;

        public ProductRepository(ApplicationDbContext context, IRestClient restClient)
        {
            _context = context;
            _restClient = restClient;

        }

        
        public Product Get(int id)
        {
            return _context.Product.Find(id);
        }

        public IEnumerable<Product> GetAll()
        {
            _restClient.Authenticator = new HttpBasicAuthenticator("77205", "19ca413e-38eb-4f90-b617-c06737464fc7");

            var request = new RestRequest();
            request.Resource = "/v2/products/?style=Gildan 2000,Gildan 5000,Gildan 12000";

            var response = _restClient.Get<List<Product>>(request);

            return response.Data;

        }
    }
}

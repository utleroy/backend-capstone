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

        //readonly ApplicationDbContext _context;
        private IRestClient _restClient;

        public ProductRepository(IRestClient restClient)
        {
            //_context = context;
            _restClient = restClient;

        }


        //public Product GetPrice(int value)
        //{
        //    var price = new RestRequest();
        //    price.Resource = "/v2/products/B00760003?fields=Sku,Gtin,Qty,SalePrice";

        //    var response = _restClient.Get(price.v);
        //    return response;
        //}

        public IEnumerable<Product> GetAll()
        {
            _restClient.Authenticator = new HttpBasicAuthenticator("77205", "19ca413e-38eb-4f90-b617-c06737464fc7");

            var request = new RestRequest();
            request.Resource = "/v2/products/81480,2839,00760?fields=SalePrice,BrandName,ColorName,SizeName";

            var response = _restClient.Get<List<Product>>(request);

            return response.Data;

        }
    }
}

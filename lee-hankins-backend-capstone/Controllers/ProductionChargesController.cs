using lee_hankins_backend_capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace lee_hankins_backend_capstone.Controllers
{
    public class ProductionChargesController : ApiController
    {
        private ProductionChargesRepository _productionChargesRepository;

        public ProductionChargesController(ProductionChargesRepository productionChargesRepository)
        {
            _productionChargesRepository = productionChargesRepository;
        }
        // GET: api/ProductionCharges
        public IEnumerable<PrintCharges> Get()
        {
            return _productionChargesRepository.GetAll();
        }

       
    }
}

﻿using lee_hankins_backend_capstone.Models;
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
        public IEnumerable<ProductionCharges> Get()
        {
            return _productionChargesRepository.GetAll();
        }

        // GET: api/ProductionCharges/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ProductionCharges
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ProductionCharges/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ProducitonCharges/5
        public void Delete(int id)
        {
        }
    }
}

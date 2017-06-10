using lee_hankins_backend_capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace lee_hankins_backend_capstone.Controllers
{

    [RoutePrefix("api/ProductionCharges")]
    public class ProductionChargesRepository
    {
        readonly ApplicationDbContext _context;
        private ProductionCharges newProductionCharges;

        public ProductionChargesRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Save(Models.ProductionCharges newProductonCharges)
        {
            _context.ProductionCharges.Add(newProductionCharges);
            _context.SaveChanges();
        }

        public ProductionCharges Get(int id)
        {
            return _context.ProductionCharges.Find(id);
        }

        public IEnumerable<Models.ProductionCharges> GetAll()
        {
            return _context.ProductionCharges;
        }

    }
}
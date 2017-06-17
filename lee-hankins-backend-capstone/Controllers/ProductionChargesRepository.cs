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

        public ProductionChargesRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<PrintCharges> GetAll()
        {
            return _context.PrintCharges;
        }

    }
}
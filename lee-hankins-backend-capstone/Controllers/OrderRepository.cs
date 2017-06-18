using lee_hankins_backend_capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace lee_hankins_backend_capstone.Controllers
{
    [RoutePrefix("api/order")]
    public class OrderRepository
    {
        readonly ApplicationDbContext _context;

        public OrderRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Save(Models.Order newOrder)
        {
            _context.Order.Add(newOrder);
            _context.SaveChanges();
        }

        public Order Get(int id)
        {
            return _context.Order.Find(id);
        }

        public IEnumerable<Models.Order> GetAll()
        {
            return _context.Order;
        }

        public void Delete(int id)
        {
            _context.Order.Remove(_context.Order.Find(id));
            _context.SaveChanges();
        }
    }
}
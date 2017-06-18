
using lee_hankins_backend_capstone.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity;

using System.Linq;
using System.Web.Hosting;
using System.Web.Http;

namespace lee_hankins_backend_capstone.Controllers
{
    [RoutePrefix("api/customer")]
    public class CustomerRepository 
    {

        readonly ApplicationDbContext _context;

        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Save(Models.Customer newCustomer)
        {
            newCustomer.DateActive = DateTime.Now;
            _context.Customer.Add(newCustomer);
            _context.SaveChanges();
        }

        public Customer Get(int id)
        {
            return _context.Customer.Find(id);
        }

        public IEnumerable<Models.Customer> GetAll()
        {
            return _context.Customer;
        }

        public void Delete(int id)
        {
            _context.Customer.Remove(_context.Customer.Find(id));
            _context.SaveChanges();
        }

    }
}

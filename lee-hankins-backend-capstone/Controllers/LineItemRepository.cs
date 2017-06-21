using lee_hankins_backend_capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace lee_hankins_backend_capstone.Controllers
{
    public class LineItemRepository
    {
        readonly ApplicationDbContext _context;

        public LineItemRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Save(Models.LineItem newLineItem)
        {
            _context.LineItem.Add(newLineItem);
            _context.SaveChanges();
        }

        internal IEnumerable<LineItem> GetAll()
        {
            return _context.LineItem;
        }

        public LineItem Get(int id)
        {
            return _context.LineItem.Find(id);
        }

        public void Delete(int id)
        {
            _context.LineItem.Remove(_context.LineItem.Find(id));
            _context.SaveChanges();
        }
    }
}
using lee_hankins_backend_capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lee_hankins_backend_capstone.Interfaces
{
    interface IOrderInterface
    {
        void Save(Order newOrder);
        Order Get(int id);
        IEnumerable<Order> GetAll();
    }
}

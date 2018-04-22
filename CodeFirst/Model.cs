using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirst
{
    
        public class User
        {
            public int Id { get; set; }
            public string Sername { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public int Age { get; set; }
            
            public virtual List<Order> Orders { get; set; }
        }

        public class Order
        {
            public int OrderId { get; set; }
            public string ProductName { get; set; }
            public int Count { get; set; }
            public DateTime PurchaseDate { get; set; }

            public User User { get; set; }
        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirst;
namespace Entity_Framework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context())
            {
                var order = context.Orders.ToList();
            }
        }
    }
}

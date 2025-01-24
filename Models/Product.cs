using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDb.Models
{
    internal class Product
    {
        public int ProductId { get; set; }
        public String Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public List<Sale> Sales { get; set; }

    }
}

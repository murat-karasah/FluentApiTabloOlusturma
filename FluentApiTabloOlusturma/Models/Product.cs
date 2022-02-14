using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentApiTabloOlusturma.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public ICollection<SuplierProduct> SuplierProduct { get; set; }
        public ProductDetails ProductDetails { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentApiTabloOlusturma.Models
{
    public class SuplierProduct
    {
        public int SupplierID { get; set; }
        public Suplier Suplier { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }

    }
}

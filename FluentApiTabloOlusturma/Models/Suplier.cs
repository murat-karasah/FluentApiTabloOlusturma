using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentApiTabloOlusturma.Models
{
    public class Suplier
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public ICollection<SuplierProduct> SuplierProduct { get; set; }


    }
}

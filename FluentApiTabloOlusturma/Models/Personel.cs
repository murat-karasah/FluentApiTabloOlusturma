using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentApiTabloOlusturma.Models
{
    public class Personel
    {
        public int Anahtar { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string EmailAdres { get; set; }
        public string Aciklama { get; set; }
        public int firID { get; set; }
        public Firma Firma { get; set; }



    }
}

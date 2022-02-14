using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentApiTabloOlusturma.Models
{
    public class Firma
    {
        
        public int Anahtar { get; set; }
        public string Unvan{ get; set; }
        public string TelefonNo{ get; set; }
        public string Adres{ get; set; }
        public string EmailAdres{ get; set; }
        public string FirmaLisansKey{ get; set; }
        public ICollection<Personel> personel { get; set; }



    }
}
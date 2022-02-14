﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentApiTabloOlusturma.Models
{
    public class ProductDetails
    {

        public int ID { get; set; }
        public string Color { get; set; }
        public int Size { get; set; }
        public Product Product { get; set; }
        public int ProID { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABPD_05.Model
{
    public class Product
    {
        public int IdProduct { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}

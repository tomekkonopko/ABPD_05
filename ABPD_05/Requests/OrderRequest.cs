using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ABPD_05.Requests
{
    public class OrderRequest
    {

        [Required]
        public int IdProduct { get; set; }
        [Required]
        public int IdWarehouse { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public DateTime CreateAt { get; set; }
    }
}

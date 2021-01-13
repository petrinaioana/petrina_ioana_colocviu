using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace petrina_ioana_colocviu.Models
{
    public class Coffee
    {
        public int ID { get; set; }
        [Display(Name = "Cup of coffee")]
        public string CoffeeType { get; set; }
        public string Size { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        

    }
}

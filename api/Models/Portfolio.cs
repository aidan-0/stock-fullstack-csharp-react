using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    [Table("Portfolios")]
    public class Portfolio
    {
        public string AppUserId { get; set; } // Foreign Key
        public int StockId { get; set; } // Foreign Key
        public AppUser AppUser { get; set; }
        public Stock Stock { get; set; }

    }
}
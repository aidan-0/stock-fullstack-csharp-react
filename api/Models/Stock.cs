using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string Symbol { get; set; } = string.Empty; // e.g. AAPL
        public string CompanyName { get; set; } = string.Empty; // e.g. Apple Inc.

        [Column(TypeName = "decimal(18, 2)")] // 18 digits, 2 decimal places
        public decimal Purchase { get; set; }
        [Column(TypeName = "decimal(18, 2)")] // 18 digits, 2 decimal places
        public decimal LastDiv { get; set; }
        public string Industry { get; set; } = string.Empty;
        public long MarketCap { get; set; }
        
        public List<Comment> Comment { get; set; } = new List<Comment>();
    }
}
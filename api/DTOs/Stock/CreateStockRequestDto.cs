using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.DTOs.Stock
{
    public class CreateStockRequestDto
    {
        public string Symbol { get; set; } = string.Empty; // e.g. AAPL
        public string CompanyName { get; set; } = string.Empty; // e.g. Apple Inc.
        public decimal Purchase { get; set; }
        public decimal LastDiv { get; set; }
        public string Industry { get; set; } = string.Empty;
        public long MarketCap { get; set; }
    }
}
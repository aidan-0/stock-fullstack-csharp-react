using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.DTOs.Stock
{
    public class CreateStockRequestDto
    {
        [Required]
        [MaxLength(10, ErrorMessage = "Symbol cannot be longer than 10 characters")]
        public string Symbol { get; set; } = string.Empty; // e.g. AAPL

        [Required]
        [MaxLength(30, ErrorMessage = "Symbol cannot be longer than 10 characters")]
        public string CompanyName { get; set; } = string.Empty; // e.g. Apple Inc.

        [Required]
        [Range(1, 1000000000)]
        public decimal Purchase { get; set; }

        [Required]
        [Range(0.001, 100)]
        public decimal LastDiv { get; set; }

        [Required]
        [MaxLength(25, ErrorMessage = "Industry cannot be over 25 characters in length")]
        public string Industry { get; set; } = string.Empty;

        [Required]
        [Range(1, 5000000000)]
        public long MarketCap { get; set; }
    }
}
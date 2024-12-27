using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Stock
{
    public class UpdateStockRequestDto
    {
        [Required]
        [MaxLength(10, ErrorMessage = "Symbol can not be more than 10 characters long")]

        public string Symbol { get; set; } = string.Empty;
        [Required]
        [MaxLength(10, ErrorMessage = "Company name can not be more than 10 characters long")]

        public string CompanyName { get; set; } = string.Empty;
        [Required]
        [Range(0, 1000000000, ErrorMessage = "Price must be between 0 and 1000000000")]
        public decimal Purchase { get; set; }
        [Required]
        [Range(0.001, 100, ErrorMessage = "Price must be between 0.001 and 100")]

        public decimal LastDiv { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "Industry can not be more than 10 characters long")]
        public string Industry { get; set; } = string.Empty;
        [Required]
        [Range(1000000000, 5000000000, ErrorMessage = "Market cap must be between 0 and 1000000000")]
        public long MarketCap { get; set; }
    }
}
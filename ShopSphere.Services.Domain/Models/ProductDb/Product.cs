using ShopSphere.Services.Domain.Common;
using ShopSphere.Services.Domain.Models.SellersDb;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSphere.Services.Domain.Models.ProductDb
{
    /// <summary>
    /// 
    /// </summary>
    
    [Table("Products")]
    public class Product : BaseEntity
    {
        public int SellerId { get; set; }

        public string ProductName { get; set; } = string.Empty; // Fixed Typo
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }

        public int StockQuantity { get; set; } // Ensure non-negative

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!; // Navigation Property

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Set only once
        public DateTime UpdatedAt { get; set; }

        public string? ModifiedBy { get; set; } 
    }
}
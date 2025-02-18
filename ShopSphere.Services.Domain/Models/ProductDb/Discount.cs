using ShopSphere.Services.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSphere.Services.Domain.Models.ProductDb
{
    /// <summary>
    /// 
    /// </summary>
    public class Discount : BaseEntity
    {
        public string DiscountCode { get; set; } = string.Empty;
        public decimal Percentage { get; set; }

        public int UsageLimit { get; set; } // Maximum allowed uses
        public int UsageCount { get; set; } // Current number of uses

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public ICollection<Product> Products { get; set; } = new List<Product>();
        public ICollection<UserDiscount> UserDiscounts { get; set; } = new List<UserDiscount>(); // Track which users used the discount
    }
}
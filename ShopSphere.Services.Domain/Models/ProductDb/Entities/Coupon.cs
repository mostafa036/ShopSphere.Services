using ShopSphere.Services.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSphere.Services.Domain.Models.ProductDb.Entities
{
    public class Coupon : BaseEntity
    {
        public string CouponCode { get; set; } = string.Empty;
        public decimal DiscountAmount { get; set; }  // Fixed amount discount
        public double DiscountPercentage { get; set; }  // Percentage discount
        public decimal MinimumOrderAmount { get; set; } // Minimum order value to apply the coupon
        public int MaxUsage { get; set; } // How many times the coupon can be used
        public int UsedCount { get; set; } = 0; // Tracks the number of times used
        public DateTime ExpiryDate { get; set; } // Coupon expiration date
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; } = true; // Whether the coupon is valid

        public Guid ProductID { get; set; }
        public Product Product { get; set; } = null!;

        public ICollection<UserCoupon> UserCoupons { get; set; } = new List<UserCoupon>(); // Fixed relation
    }
}

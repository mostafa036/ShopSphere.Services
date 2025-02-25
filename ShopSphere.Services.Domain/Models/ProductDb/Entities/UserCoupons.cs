using ShopSphere.Services.Domain.Common;


namespace ShopSphere.Services.Domain.Models.ProductDb.Entities
{

    /// <summary>
    ///  To track which users have used the coupon, we create a many-to-many relationship
    /// </summary>
    public class UserCoupon : BaseEntity
    {
        public string CustomerEmail { get; set; } = string.Empty;
        public Guid CouponId { get; set; }
        public Coupon Coupon { get; set; } = null!;

        public Guid ProductId { get; set; }
        public Product Product { get; set; } = null!;

        public DateTime UsedAt { get; set; }
    }
}

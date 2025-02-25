using ShopSphere.Services.Domain.Common;

namespace ShopSphere.Services.Domain.Models.ProductDb.Entities
{
    public class ProductDiscount : DiscountBase
    {
        public Guid ProductId { get; private set; }
        public virtual Product Product { get; private set; } = null!;
        private ProductDiscount() { }

        public ProductDiscount(string discountName, decimal discountPercentage, decimal discountAmount,
                               DateTime startDate, DateTime endDate, Guid productId)
            : base(discountName, discountPercentage, discountAmount, startDate, endDate)
        {
            ProductId = productId;
        }
    }
}
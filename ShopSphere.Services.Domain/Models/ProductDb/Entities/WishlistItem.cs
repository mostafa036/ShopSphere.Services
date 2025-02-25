using ShopSphere.Services.Domain.Common;

namespace ShopSphere.Services.Domain.Models.ProductDb.Entities
{
    public class WishlistItem : BaseEntity
    {
        public Guid ProductId { get; set; }
        public Product Product { get; set; } = null!;

        public Guid WishlistId { get; set; }
        public Wishlist Wishlist { get; set; } = null!;

        public DateTime AddedAt { get; set; }
    }
} 
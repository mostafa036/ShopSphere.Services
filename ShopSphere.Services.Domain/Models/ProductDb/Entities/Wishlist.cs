using ShopSphere.Services.Domain.Common;

namespace ShopSphere.Services.Domain.Models.ProductDb.Entities
{
    public class Wishlist : BaseEntity
    {
        public string CustomerEmail { get; set; } = string.Empty;
        public ICollection<WishlistItem> WishlistItems { get; set; } = new List<WishlistItem>();
    }
}
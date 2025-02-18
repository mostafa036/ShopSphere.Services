using ShopSphere.Services.Domain.Common;

namespace ShopSphere.Services.Domain.Models.ProductDb
{
    public class Wishlist : BaseEntity
    {
        public int CustomerId { get; set; }
        public  Customer { get; set; }
        public ICollection<WishlistItem> WishlistItems { get; set; }
    }
}
using ShopSphere.Services.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSphere.Services.Domain.Models.ProductDb
{
    public class WishlistItem : BaseEntity
    {
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;

        public int WishlistId { get; set; }
        public Wishlist Wishlist { get; set; } = null!;

        public DateTime AddedAt { get; set; } = DateTime.UtcNow; // Track when added


    }
}

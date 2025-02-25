using ShopSphere.Services.Domain.Common;

namespace ShopSphere.Services.Domain.Models.ProductDb.Entities
{
    public class ProductInventories : BaseEntity
    {
        public int Quantity { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}

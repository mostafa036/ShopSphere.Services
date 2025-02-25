using ShopSphere.Services.Domain.Common;

namespace ShopSphere.Services.Domain.Models.ProductDb.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public ICollection<Product> Products { get; set; } = new List<Product>();
        public ICollection<CategoryDiscount> CategoryDiscount { get; set; } = new List<CategoryDiscount>();
    }
}

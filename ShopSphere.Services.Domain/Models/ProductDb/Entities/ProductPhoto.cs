using ShopSphere.Services.Domain.Common;

namespace ShopSphere.Services.Domain.Models.ProductDb.Entities
{

    public class ProductPhoto : BaseEntity
    {
        public string PhotoPath { get; set; } = string.Empty;
        public string PhotoName { get; set; } = string.Empty;
        public bool IsPrimary { get; set; } = false;

        public Guid ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }
}

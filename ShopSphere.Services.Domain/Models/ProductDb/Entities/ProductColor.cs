using ShopSphere.Services.Domain.Common;

namespace ShopSphere.Services.Domain.Models.ProductDb.Entities
{
    public class ProductColor : BaseEntity
    {
        public string ColorName { get; set; }  = string.Empty;
        public string HexCode { get; set; } = string.Empty;
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}

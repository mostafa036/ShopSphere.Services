using ShopSphere.Services.Domain.Common;

namespace ShopSphere.Services.Domain.Models.ProductDb.OrderAggregation
{
    public class ShippingMethod : BaseEntity
    {
        public string Name { get; set; } = string.Empty; // e.g., Standard, Express, Overnight
        public decimal Cost { get; set; }
        public int EstimatedDays { get; set; } // Estimated delivery time
    }
}

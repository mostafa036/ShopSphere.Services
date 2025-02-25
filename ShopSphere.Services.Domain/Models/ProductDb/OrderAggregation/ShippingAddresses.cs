using ShopSphere.Services.Domain.Common;

namespace ShopSphere.Services.Domain.Models.ProductDb.OrderAggregation
{
    public class ShippingAddress : BaseEntity
    {
        public int UserId { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string AddressLine1 { get; set; } = string.Empty;
        public string? AddressLine2 { get; set; }
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string PhoneNumber1 { get; set; } = string.Empty;
        public string PhoneNumber2 { get; set; } = string.Empty;
    }
}
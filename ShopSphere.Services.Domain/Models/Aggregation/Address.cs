
namespace ShopSphere.Services.Domain.Models.Aggregation
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Street { get; private set; } = string.Empty;
        public string City { get; private set; } = string.Empty;
        public string State { get; private set; } = string.Empty;
        public string PostalCode { get; private set; } = string.Empty;
        public string AddressType { get; private set; } = string.Empty;
        public string IsPrimary { get; private set; } = string.Empty;
        public string UserId { get; set; } = null!;
    }
}
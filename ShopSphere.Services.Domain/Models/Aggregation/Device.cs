
namespace ShopSphere.Services.Domain.Models.Aggregation
{
    public class Device
    {
        public int DeviceId { get; set; }
        public string DeviceName { get; private set; } = string.Empty;
        public string IPAddress { get; private set; } = string.Empty;
        public DateTime LastUsed { get; set; }
        public int DeviceType { get; set; }
        public string UserId { get; set; } = null!;
        public int RegionId { get; set; }
        public Region Region { get; set; } = null!;
    }
}

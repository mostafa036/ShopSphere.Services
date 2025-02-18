using Microsoft.AspNet.Identity.EntityFramework;
using ShopSphere.Services.Domain.Enums;


namespace ShopSphere.Services.Domain.Models.CustomerDb
{
    /// <summary>
    /// 
    ///
    /// </summary>
    public class Seller : IdentityUser
    {
        public string DisplayName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string Zip { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public UserStatus Status { get; set; } = UserStatus.Pending;
        public string? ModifiedBy { get; set; } // Consider storing UserId instead of a string

        // Timestamps
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;


        public ICollection<Profile> Profiles { get; set; } = new HashSet<Profile>();
    }

}


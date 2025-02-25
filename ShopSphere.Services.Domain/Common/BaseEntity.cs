using System.ComponentModel.DataAnnotations;

namespace ShopSphere.Services.Domain.Common
{
    public abstract class BaseEntity
    {
        [Key]
        public Guid ID { get; set; } = Guid.NewGuid();
        public DateTime CreatedAt { get; set; } 
        public DateTime UpdatedAt { get; set; } 
        public DateTime? DeletedAt { get; set; }
    }
}

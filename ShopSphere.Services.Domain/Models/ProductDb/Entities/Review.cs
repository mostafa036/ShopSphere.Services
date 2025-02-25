using ShopSphere.Services.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace ShopSphere.Services.Domain.Models.ProductDb.Entities
{
    /// <summary>
    ///    
    /// </summary>
    public class Review : BaseEntity
    {
        public string Comment { get; set; } = string.Empty;

        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5 stars.")]
        public int Rating { get; set; }
        public DateTime ReviewDate { get; set; } 

        public Guid ProductId { get; set; }
        public Product Product { get; set; } = null!;

        [EmailAddress]
        public string CustomerEmail { get; set; } = string.Empty;
    }
}
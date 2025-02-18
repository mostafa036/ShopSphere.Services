using ShopSphere.Services.Domain.Models.Aggregation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSphere.Services.Domain.Models.CustomerDb
{
    public class SellerProfile : Profile
    {
        public string SellerId { get; set; } = null!;  // Seller-specific identifier
        public Seller Seller { get; set; } = null!;  // Navigation property to Seller
        public string BusinessName { get; set; } = string.Empty;  // Example of seller-specific info
        public string BusinessAddress { get; set; } = string.Empty;
    }
}
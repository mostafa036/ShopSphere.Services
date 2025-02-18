using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSphere.Services.Domain.Models.ProductDb
{
    public class UserDiscount
    {
        public int UserId { get; set; }

        public   User { get; set; } = null!;

        public int DiscountId { get; set; }
        public Discount Discount { get; set; } = null!;

        public DateTime UsedAt { get; set; } = DateTime.UtcNow;
    }
}

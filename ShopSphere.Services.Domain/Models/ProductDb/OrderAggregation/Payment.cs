using ShopSphere.Services.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSphere.Services.Domain.Models.ProductDb.OrderAggregation
{
    public class Payment : BaseEntity
    { 
        public int OrderId { get; set; }
        public int PaymentMethodId { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; } = "Pending";
        //public Order Order { get; set; }
        public PaymentMethod PaymentMethod { get; set; } = null!;
    }
}

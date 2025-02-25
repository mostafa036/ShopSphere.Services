using ShopSphere.Services.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSphere.Services.Domain.Models.ProductDb.OrderAggregation
{
    public class Refund : BaseEntity
    {
        public int TransactionId { get; set; }
        public decimal Amount { get; set; }
        public string Reason { get; set; } = string.Empty;  
        public Transactions Transaction { get; set; } = null!;
    }
}

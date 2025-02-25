using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSphere.Services.Domain.Models.ProductDb.OrderAggregation
{
    public class Transactions
    {
        public int Id { get; set; }
        public int PaymentId { get; set; }
        public string TransactionType { get; set; } = string.Empty; // 'Charge', 'Refund'
        public string Status { get; set; } = "Processing";
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public Payment Payment { get; set; } = null!;
    }
}

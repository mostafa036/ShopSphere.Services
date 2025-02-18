using ShopSphere.Services.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSphere.Services.Domain.Models.ProductDb
{
    public class Review : BaseEntity
    {
        public string Comment { get; set; } = string.Empty;
        public int Rating { get; set; }
        public DateTime ReviewDate { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        public string CustomerEmail { get; set; } = string.Empty;
        public string CustomerEmailName { get; set; } = string.Empty;
    }
}
using ShopSphere.Services.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSphere.Services.Domain.Models.ProductDb.Entities
{
    public class CategoryDiscount : DiscountBase
    {
        public Guid CategoryId { get; private set; }
        public virtual Category Category { get; private set; } = null!;
        private CategoryDiscount() { }

        public CategoryDiscount(string discountName, decimal discountPercentage, decimal discountAmount,
                                DateTime startDate, DateTime endDate, Guid categoryId)
            : base(discountName, discountPercentage, discountAmount, startDate, endDate)
        {
            CategoryId = categoryId;
        }
    }
}

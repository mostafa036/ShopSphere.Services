using ShopSphere.Services.Domain.Common;

namespace ShopSphere.Services.Domain.Models.ProductDb.Entities
{
    public abstract class DiscountBase : BaseEntity 
    {
        public string? DiscountName { get; private set; }
        public decimal DiscountPercentage { get; private set; }
        public decimal? DiscountAmount { get; private set; }

        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }

        public bool IsActive { get; private set; } = true;
        protected DiscountBase() { }

        protected DiscountBase(string discountName, decimal discountPercentage, decimal discountAmount,
                               DateTime startDate, DateTime endDate)
        {
            if (startDate >= endDate)
                throw new ArgumentException("Start date must be earlier than the end date.");

            DiscountName = discountName;
            DiscountPercentage = discountPercentage;
            DiscountAmount = discountAmount;
            StartDate = startDate;
            EndDate = endDate;
        }

        public void UpdateDiscount(decimal percentage, decimal amount, DateTime start, DateTime end)
        {
            if (start >= end)
                throw new ArgumentException("Start date must be earlier than the end date.");

            DiscountPercentage = percentage;
            DiscountAmount = amount;
            StartDate = start;
            EndDate = end;
        }

        public void Activate() => IsActive = true;
        public void Deactivate() => IsActive = false;
    }
} 
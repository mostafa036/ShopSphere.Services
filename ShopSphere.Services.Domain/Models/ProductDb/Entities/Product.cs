using ShopSphere.Services.Domain.Common;

namespace ShopSphere.Services.Domain.Models.ProductDb.Entities
{
    public class Product : BaseEntity
    {
        public int SellerId { get; set;}
        public string ProductName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string SKU { get; set; } = string.Empty;
        public decimal? DiscountedPrice { get; set; }
        public string Department { get; set; } = string.Empty;
        public string ModifiedBy { get; set; } = string.Empty;

       
        // Navigation Properties[One]
        public Guid CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        public Guid BrandId { get; set; }
        public ProductBrand Brand { get; set; } = null!;
        public ProductDiscount Discount { get; set; } = null!;
        public Coupon Coupon { get; set; } = null!;

        public Guid ProductInventoriesID { get; set; }
        public ProductInventories productInventories { get; set; } = null!;



        public ICollection<UserCoupon> UserCoupons { get; set; } = new List<UserCoupon>();
        //    Navigation Properties [Many]
        public ICollection<ProductColor> productColors { get; set; } = new List<ProductColor>(); 
        public ICollection<ProductPhoto> productPhotos { get; set; } = new List<ProductPhoto>();
        public ICollection<Review> reviews { get; set; } = new List<Review>();
        public ICollection<WishlistItem> WishlistItems { get; set; } = new List<WishlistItem>();
    }
}
using Microsoft.AspNet.Identity;
using ShopSphere.Services.Domain.Models.SellersDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSphere.Services.Domain.Models.Aggregation
{
    /// <summary>
    /// 
    /// </summary>
    public class Profile
    {
        public int UserProfileId { get; set; }
        public string Nickname { get; private set; } = string.Empty;
        public string Languages { get; private set; } = "ENG";
        public bool IsAdult { get; set; }
        public ProfilePhotoes profilePhotoes { get; set; } = null!;
        public string UserId { get; set; } = null!;
    }
}
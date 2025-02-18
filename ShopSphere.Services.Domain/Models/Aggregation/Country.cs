using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSphere.Services.Domain.Models.Aggregation
{
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; private set; } = string.Empty;
        public int RegionsId { get; set; }
        public Region Regions { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSphere.Services.Domain.Models.Aggregation
{
    /// <summary>
    /// 
    /// </summary>
    public class Region
    {
        public int RegionId { get; set; }
        public string RegionName { get; private set; } = string.Empty;
        public ICollection<Device> Devices { get; set; } = new HashSet<Device>();
        public ICollection<Country> Countries { get; set; } = new HashSet<Country>();
    }
}
﻿using ShopSphere.Services.Domain.Models.SellersDb;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSphere.Services.Domain.Models.Aggregation
{
    /// <summary>
    /// 
    /// </summary>
    public class ProfilePhotoes
    {
        public Guid PhotoId { get; set; }
        public string FileName { get; private set; } = string.Empty;
        public string FilePath { get; private set; } = string.Empty;
        public string PhotoType { get; private set; } = string.Empty;
        public long FileSize { get; set; }
        public DateTime UploadDate { get; set; }
        public int UserProfileId { get; set; }
        public UserProfile UserProfile { get; set; } = null!;
    }
}

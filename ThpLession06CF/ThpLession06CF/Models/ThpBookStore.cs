using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ThpLession06CF.Models
{
    public class ThpBookStore : DbContext
    {
        public ThpBookStore():base("TvcBookStoreConnectionString") { }
        // Khai bao cac thuoc tinh tuong ung vs cac bang trong co so du lieu
        public DbSet<ThpCategory> ThpCategories { get; set; }
        public DbSet<ThpBook> ThpBooks { get; set; }
    }
}
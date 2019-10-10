using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Web_API_Demo.Models
{
    public class ItemsContext : DbContext
    {
        public DbSet<Items> Items { set; get; }
    }
}
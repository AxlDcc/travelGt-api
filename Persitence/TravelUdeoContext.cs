using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TravelUdeoBackend.Core.Domain;

namespace TravelUdeoBackend.Persitence
{
    public class TravelUdeoContext : DbContext
    {
        public TravelUdeoContext()
            : base("name=TravelUdeoContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Hotel> Hotels { get; set; }
    }
}
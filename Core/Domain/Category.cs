using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelUdeoBackend.Core.Domain
{
    public class Category
    {
        public Category()
        {
            Locations = new HashSet<Location>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        [JsonIgnore]
        public  ICollection<Location> Locations { get; set; }
    }
}
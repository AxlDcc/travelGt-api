using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelUdeoBackend.Core.Domain
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string UrlImg { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Views { get; set; }
        public bool isPopular { get; set; }
        public  Category Category { get; set; }
        public  Region Region { get; set; }

    }
}
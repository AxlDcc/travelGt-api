using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TravelUdeoBackend.Core.Domain;
using TravelUdeoBackend.Persitence;

namespace TravelUdeoBackend.Controllers.API
{
    public class RegionsController : ApiController
    {
        private TravelUdeoContext _context;

        public RegionsController()
        {
            _context = new TravelUdeoContext();
        }
        public IEnumerable<Region> GetRegions()
        {
            return _context.Regions.ToList();
        }
    }
}

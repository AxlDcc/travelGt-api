using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TravelUdeoBackend.Core.Domain;
using TravelUdeoBackend.Persitence;
using System.Data.Entity;
using TravelUdeoBackend.Models;


namespace TravelUdeoBackend.Controllers.API
{
    public class LocationsController : ApiController
    {
        private TravelUdeoContext _context;

        public LocationsController()
        {
            _context = new TravelUdeoContext();
        }

        public IEnumerable<Location> GetLocations()
        {
            return _context.Locations.Include(c => c.Category).Include(r => r.Region).ToList();
        }
        [HttpPost]
        public IEnumerable<Location> GetLocationsClose(Coordinate coordinate)
        {
            var locations = _context.Locations.Include(c => c.Category);
            return EngineLocation.closeLocations(locations, coordinate);
        }
    }
}

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
    public class CategoriesController : ApiController
    {
        private TravelUdeoContext _context;

        public CategoriesController()
        {
            _context = new TravelUdeoContext();
        }

        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }
    }
}

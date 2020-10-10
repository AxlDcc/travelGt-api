using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelUdeoBackend.Core.Domain;
using TravelUdeoBackend.Models;

namespace TravelUdeoBackend.Persitence
{
    public class EngineLocation
    {
        static double _eQuatorialEarthRadius = 6378.1370D;
        static double _d2r = (Math.PI / 180D);

        public static int HaversineInM(double lat1, double long1, double lat2, double long2)
        {
            return (int)(1000D * HaversineInKM(lat1, long1, lat2, long2));
        }

        public static double HaversineInKM(double lat1, double long1, double lat2, double long2)
        {
            double dlong = (long2 - long1) * _d2r;
            double dlat = (lat2 - lat1) * _d2r;
            double a = Math.Pow(Math.Sin(dlat / 2D), 2D) + Math.Cos(lat1 * _d2r) * Math.Cos(lat2 * _d2r) * Math.Pow(Math.Sin(dlong / 2D), 2D);
            double c = 2D * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1D - a));
            double d = _eQuatorialEarthRadius * c;

            return d;
        }
        public static IEnumerable<Location> closeLocations(IEnumerable<Location> locations, Coordinate coordinate)
        {
            //locations = new List<Location>();
            List<Location> newLocation = new List<Location>();
            double limit = 1000;
            double distance;

            foreach (var item in locations)
            {
                distance = HaversineInM(coordinate.Latitude, coordinate.Longitude, item.Latitude, item.Longitude);
                if (distance <= limit)
                {
                    newLocation.Add(item);
                }
            }

            return newLocation;
        }
    }
}
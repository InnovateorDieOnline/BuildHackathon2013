using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;

namespace LiveCycle.Models
{
    public class Landmark
    {
        public GeoCoordinate Geocoordinate { get; set; }
        public string Name { get; set; }
    }
}

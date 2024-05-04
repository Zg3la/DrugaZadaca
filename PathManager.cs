using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca2
{
    public class PathManager
    {
        private List<Location> Locations;

        public PathManager()
        {
            Locations = new List<Location>();
        }

        public void Add(Location location)
        {
            Locations.Add(location);
        }

        public void Remove(Location location)
        {
            Locations.Remove(location);
        }

    }
}

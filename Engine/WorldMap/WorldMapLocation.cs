using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class WorldMapLocation
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int LocationToNorth { get; set; }
        public int LocationToEast { get; set; }
        public int LocationToSouth { get; set; }
        public int LocationToWest { get; set; }
    }
}
using SmallWorld.src.Interfaces;
using SmallWorld.src.Model.Terrain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWorld.src.Model.Map
{
    internal class Map
    {
        private List<Land> lands;
        internal List<Land> Lands { get => lands; set => lands = value; }
        public Map(List<Land> lands)
        {
            Lands = lands;
        }
        public Map() { }
    }
}

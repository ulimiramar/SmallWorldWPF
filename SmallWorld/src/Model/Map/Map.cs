using SmallWorld.src.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWorld.src.Model.Map
{
    internal class Map
    {
        List<ITerrain> Terrains = new List<ITerrain>();

        public Map(List<ITerrain> terrains)
        {
            Terrains = terrains;
        }
    }
}

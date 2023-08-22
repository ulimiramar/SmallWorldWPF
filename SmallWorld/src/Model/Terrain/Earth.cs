using SmallWorld.src.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWorld.src.Model.Terreno
{
    internal class Earth : ITerrain
    {
        private string ImageRute = $@"I:\itec3\disenio\SmallWorld-mio\SmallWorld\SmallWorld\Resources\HexagonEarth.png";

        public string getTerrainName()
        {
            return "Tierra";
        }
        public string getTerrainImageRute()
        {
            return ImageRute;
        }
    }
}

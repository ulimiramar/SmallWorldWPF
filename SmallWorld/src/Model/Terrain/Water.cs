using SmallWorld.src.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWorld.src.Model.Terreno
{
    internal class Water : ITerrain
    {
        private Bitmap ImageRute = global::SmallWorld.Properties.Resources.waterSea;

        public override string ToString()
        {
            return "Agua";
        }
        public Bitmap getTerrainImageRute()
        {
            return ImageRute;
        }
    }
}

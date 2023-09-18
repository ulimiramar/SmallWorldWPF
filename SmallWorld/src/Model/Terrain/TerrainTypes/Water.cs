using SmallWorld.src.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWorld.src.Model.Terreno
{
    internal class Water : ITerrainType
    {
        private string name = "Agua";
        private Bitmap ImageRute = global::SmallWorld.Properties.Resources.waterSea;

        public override string ToString()
        {
            return name;
        }
        public Bitmap getTerrainImageRute()
        {
            return ImageRute;
        }
    }
}

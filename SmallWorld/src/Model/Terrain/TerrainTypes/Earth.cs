using SmallWorld.src.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWorld.src.Model.Terreno
{
    internal class Earth : ITerrainType
    {
        private Bitmap ImageRute = global::SmallWorld.Properties.Resources.EarthGreen;
        

        //private string ImageRute = $@"I:\itec3\disenio\SmallWorld-mio\SmallWorld\SmallWorld\Resources\EarthGreen.jpg";

        public override string ToString()
        {
            return "Tierra";
        }
        public Bitmap getTerrainImageRute()
        {
            return ImageRute;
        }
    }
}

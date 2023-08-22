using SmallWorld.src.Interfaces;
using SmallWorld.src.Model;
using SmallWorld.src.Model.Map;
using SmallWorld.src.Model.Terreno;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SmallWorld.src.Controllers
{
    internal class MapController
    {

        private readonly static MapController MapsController = new MapController();

        private readonly List<Terrain> Terrains = new List<Terrain>();
        private readonly List<Terrain> Hexagons = new List<Terrain>();

        //TODO: Resolver cómo crear un mapa con terrenos aleatorios y colocar entidades en ellos

        private MapController() { }
        public static MapController GetController()
        {
            return MapsController;
        }


        public void GenerateMap()
        {
            //TODO: hacer aleatoria la generación de tipos de terreno
            Terrains.Add(new Terrain(1, new Earth()));
            Terrains.Add(new Terrain(2, new Water()));
            Terrains.Add(new Terrain(3, new Earth()));
        }

        public List<Terrain> GetTerrains()
        {
            return Terrains;
        }
        public string GetTerrainsImageRute()
        {
            //TODO: hacer un foreach
            return Terrains[0].TerrainType.getTerrainImageRute();
        }

        public void ShowMap()
        {
            
        }
    }
}

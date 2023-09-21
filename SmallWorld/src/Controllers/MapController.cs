using SmallWorld.src.Interfaces;
using SmallWorld.src.Model;
using SmallWorld.src.Model.Map;
using SmallWorld.src.Model.Terrain;
using SmallWorld.src.Model.Terreno;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace SmallWorld.src.Controllers
{
    internal class MapController
    {
        private LandController landController = LandController.GetInstance();
        private static MapController instance;
        private readonly Map map = new Map();
        private readonly List<IPositionable> positionables = new List<IPositionable>();
        //private readonly List<Land> landsInMap = new List<Land>();
        private MapController() { }
        public static MapController GetInstance()
        {
            if (instance == null)
            {
                instance = new MapController();
            }
            return instance;
        }

        public List<ITerrainType> terrainsTypes()
        {
            List<ITerrainType> terrainTypesList = new List<ITerrainType>();
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.GetInterfaces().Contains(typeof(ITerrainType))))
            {
                terrainTypesList.Add((ITerrainType)Activator.CreateInstance(type));
            }
            return terrainTypesList;
        }

        public void GenerateMap()
        {
            var random = new Random();
            for (int i = 0; i < 20; i++)
            {
                List<ITerrainType> terrainTypes = terrainsTypes();
                ITerrainType randomTerrain = terrainTypes[random.Next(terrainTypes.Count)];
                landController.AddLand(randomTerrain);
                //TODO: resolver de si trabajar con la controladora de lands o mapas.
                //map.Lands.Add()
            }
            //map.Lands = landController.getLands();
            //map.Lands = land
            landController.setBorderingLands();
        }
        public Map GetMap()
        {
            return map;
        }
        

        public void SetPositions()
        {
            Random random = new Random();
            foreach(IPositionable positionable in positionables)
            {
                int randomLand = random.Next(0, landController.getLands().Count);
                positionable.Position(landController.getLands()[randomLand]);
            }
        }

        public void SetPosition(IPositionable positionable)
        {
            
        }

    }
}

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
            for (int i=0; i < 20; i++)
            {
                List<ITerrainType> terrainTypes = terrainsTypes();
                ITerrainType randomTerrain = terrainTypes[random.Next(terrainTypes.Count)];
                landController.AddLand(randomTerrain);
                //TODO: resolver de si trabajar con la controladora de lands o mapas.
                //map.Lands.Add
            }
            //map.Lands = land
            setBorderingLands();
        }
        public Map GetMap()
        {
            return map;
        }
        public void setBorderingLands()
        {
            var random = new Random();
            foreach (Land land in map.Lands) 
            { 
                int numBorderingLands = random.Next(1, 7);
                //Trae todos los indices de las tierras disponibles
                List<int> availableLandIndices = Enumerable.Range(0, map.Lands.Count).ToList();
                // Elimina el índice de la tierra actual de las tierras disponibles para que no limite con ella misma
                availableLandIndices.Remove(map.Lands.IndexOf(land));
                for (int i = 0; i < numBorderingLands; i++)
                {
                    //elige aleatoriamente las tierras limitrofes
                    int randomIndex = random.Next(0, availableLandIndices.Count);
                    //asigna a una variable entera el indice de la tierra.
                    int borderingLandIndex = availableLandIndices[randomIndex];
                    //land.BorderingLands.Add(map.Lands[random.Next(map.Lands.Count)]);
                    //agrega a la lista de tierras limitrofes una tierra limitrofe.
                    land.BorderingLands.Add(map.Lands[borderingLandIndex]);
                }
            }
        }
    }
}

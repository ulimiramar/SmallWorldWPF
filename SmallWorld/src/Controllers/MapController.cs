using SmallWorld.src.Interfaces;
using SmallWorld.src.Model;
using SmallWorld.src.Model.Map;
using SmallWorld.src.Model.Terreno;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SmallWorld.src.Controllers
{
    internal class MapController
    {

        private readonly static MapController MapsController = new MapController();

        //TODO:creo que la primera lista no la voy a usar, es mejor la lista de ITerrain
        //TODO:veificar en EntityController si también es mejor usar una interface en vez de una clase
        private readonly List<Terrain> Terrains = new List<Terrain>();
        private readonly List<ITerrain> Hexagons = new List<ITerrain>();
        

        

    //TODO: Resolver como colocar entidades en los terrenos

        private MapController() { }
        public static MapController GetController()
        {
            return MapsController;
        }

        public List<Type> GetTerrainTypes()
        {
            var terrainTypes = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(t => typeof(ITerrain).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
            .ToList();
            return terrainTypes;
        }
        public void GenerateMap()
        {
            //Aqui uso reflexion para obtener las clases que usan ITerrain
            //en el bucle for instancio 20 clases de forma aleatoria

            var random = new Random();
            

            for (int i = 0; i < 20; i++)
            {
                List<Type>terrainTypes = GetTerrainTypes();

                var randomTerrainType = terrainTypes[random.Next(terrainTypes.Count)];

                var terrainInstance = (ITerrain)Activator.CreateInstance(randomTerrainType);

                Hexagons.Add(terrainInstance);
            }

        }

        public List<ITerrain> GetTerrains()
        {
            return Hexagons;
        }
        public string GetTerrainsImageRute()
        {
           
            return Terrains[0].TerrainType.getTerrainImageRute();
        }

        public void ShowMap()
        {
            
        }
    }
}

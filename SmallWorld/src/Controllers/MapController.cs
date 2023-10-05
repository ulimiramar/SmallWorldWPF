using SmallWorld.src.Interfaces;
using SmallWorld.src.Model;
using SmallWorld.src.Model.Map;
using SmallWorld.src.Model.Terrain;
using SmallWorld.src.Model.Terreno;
using SmallWorld.src.Static;
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
        private static MapController instance;
        private readonly List<Map>maps = new List<Map>();
        private readonly List<Land> Lands = new List<Land>();
        private readonly List<IPositionable> positionables = new List<IPositionable>();
        private MapController() { }
        public static MapController GetInstance()
        {
            if (instance == null)
            {
                instance = new MapController();
            }
            return instance;
        }
        public void AddLand(ITerrainType terrainType, Map map)
        {
            Land LandToAdd = new Land(terrainType);
            map.Lands.Add(LandToAdd);
        }
        public void AddBorderingLands(Land landToModify, List<Land> BorderingLandsToAdd)
        {
            foreach (Land land in BorderingLandsToAdd)
            {
                landToModify.BorderingLands.Add(land);
            }
        }
        public void AddBorderingLand(Land landToModify, Land BorderingLandToAdd)
        {
            landToModify.BorderingLands.Add(BorderingLandToAdd);
        }
        public List<Land> getLands(Map map)
        {
            return map.Lands;
        }
        public List<IPositionable> getPositionbalesInAllLands()
        {
            List<IPositionable> allPositionables = new List<IPositionable>();
            foreach (Land land in Lands)
            {
                allPositionables.AddRange(land.Positionables);
            }
            return allPositionables;
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
            Map map = new Map();
            var random = new Random();
            for (int i = 0; i < 19; i++)
            {
                List<ITerrainType> terrainTypes = terrainsTypes();
                ITerrainType randomTerrain = terrainTypes[random.Next(terrainTypes.Count)];
                AddLand(randomTerrain, map);
            }
            maps.Add(map);
            setBorderingLands(map);
            SetPositionsOfPositionableObjects(map);
        }
        public void setBorderingLands(Map map)
        {
            map.Lands[0].BorderingLands = new List<Land> { map.Lands[1], map.Lands[5], map.Lands[6] };
            map.Lands[1].BorderingLands = new List<Land> { map.Lands[0], map.Lands[6], map.Lands[7], map.Lands[2] };
            map.Lands[2].BorderingLands = new List<Land> { map.Lands[1], map.Lands[7], map.Lands[3] };
            map.Lands[3].BorderingLands = new List<Land> { map.Lands[2], map.Lands[7], map.Lands[8], map.Lands[4] };
            map.Lands[4].BorderingLands = new List<Land> { map.Lands[3], map.Lands[8], map.Lands[9] };
            map.Lands[5].BorderingLands = new List<Land> { map.Lands[0], map.Lands[6], map.Lands[11], map.Lands[10] };
            map.Lands[6].BorderingLands = new List<Land> { map.Lands[0], map.Lands[1], map.Lands[7], map.Lands[12], map.Lands[11], map.Lands[5] };
            map.Lands[7].BorderingLands = new List<Land> { map.Lands[1], map.Lands[2], map.Lands[3], map.Lands[8], map.Lands[12], map.Lands[6] };
            map.Lands[8].BorderingLands = new List<Land> { map.Lands[7], map.Lands[3], map.Lands[4], map.Lands[9], map.Lands[13], map.Lands[12] };
            map.Lands[9].BorderingLands = new List<Land> { map.Lands[4], map.Lands[8], map.Lands[13], map.Lands[14] };
            map.Lands[10].BorderingLands = new List<Land> { map.Lands[5], map.Lands[11], map.Lands[15] };
            map.Lands[11].BorderingLands = new List<Land> { map.Lands[10], map.Lands[5], map.Lands[6], map.Lands[12], map.Lands[16], map.Lands[15] };
            map.Lands[12].BorderingLands = new List<Land> { map.Lands[6], map.Lands[7], map.Lands[8], map.Lands[11], map.Lands[16], map.Lands[13] };
            map.Lands[13].BorderingLands = new List<Land> { map.Lands[12], map.Lands[8], map.Lands[9], map.Lands[14], map.Lands[17], map.Lands[16] };
            map.Lands[14].BorderingLands = new List<Land> { map.Lands[9], map.Lands[13], map.Lands[17] };
            map.Lands[15].BorderingLands = new List<Land> { map.Lands[10], map.Lands[11], map.Lands[16], map.Lands[18] };
            map.Lands[16].BorderingLands = new List<Land> { map.Lands[15], map.Lands[11], map.Lands[12], map.Lands[13], map.Lands[17], map.Lands[18] };
            map.Lands[17].BorderingLands = new List<Land> { map.Lands[14], map.Lands[13], map.Lands[16], map.Lands[18] };
            map.Lands[18].BorderingLands = new List<Land> { map.Lands[15], map.Lands[16], map.Lands[17] };
        }
        public void setBorderingLandsRandomly(Map map)
        {
            var random = new Random();

            foreach (Land land in getLands(map))
            {
                int numBorderingLands = random.Next(1, 7);
                List<int> availableLandIndices = Enumerable.Range(0, getLands(map).Count).ToList();
                availableLandIndices.Remove(getLands(map).IndexOf(land));

                for (int i = 0; i < numBorderingLands; i++)
                {
                    if (availableLandIndices.Count > 0)
                    {
                        int randomIndex = random.Next(0, availableLandIndices.Count);
                        int borderingLandIndex = availableLandIndices[randomIndex];
                        if (!land.BorderingLands.Contains(getLands(map)[borderingLandIndex]) && land.BorderingLands.Count < 6 && getLands(map)[borderingLandIndex].BorderingLands.Count < 6)
                        {
                            AddBorderingLand(land, getLands(map)[borderingLandIndex]);
                            AddBorderingLand(getLands(map)[borderingLandIndex], land);
                        }
                    }
                }
            }
        }
        public List<Map> GetMaps()
        {
            return maps;
        }
        public List<Land> getBorderingLands(Land land)
        {
            return land.BorderingLands;
        }


        public void SetPositionsOfPositionableObjects(Map map)
        {
            Random random = new Random();
            foreach(IPositionable positionable in PositionableObjectRegistry.GetAllPositionableObjects())
            {
                int randomLand = random.Next(0, getLands(map).Count);
                //TODO: resolver como colocar en el mapa las entidades según su habitat.
                //if(getLands(map)[randomLand].TerrainType.getHabitatsSupported().Contains())
                getLands(map)[randomLand].Positionables.Add(positionable);
                //positionable.Position(getLands(map)[randomLand]);
            }
        }
        public List<IPositionable> GetPositionablesInLand(Land land)
        {
            return land.Positionables;
        }

        //Generics para traer IPositionables según la clase.
        public List<T> GetPositionablesInLand<T>(Land land) where T : IPositionable
        {
            return land.Positionables.OfType<T>().ToList();
        }


        public void MoveMovible2(Land landOrigin, Land landDestiny, Entity entity)
        {
            List<IPositionable> MoviblesToRemove = new List<IPositionable>();

            foreach (IPositionable p in landOrigin.Positionables)
            {
                if (p.Equals(entity))
                {
                    MoviblesToRemove.Add(p);
                    landDestiny.Positionables.Add(p);
                    break;
                }
            }

            foreach (IPositionable p in MoviblesToRemove)
            {
                landOrigin.Positionables.Remove(p);
            }
        }

        public void MoveMovible(Land landOrigin, Land landDestiny, Entity entity)
        {
            foreach(var habitat in entity.HabitatList)
            {
                if (landDestiny.TerrainType.getHabitatsSupported().Contains(habitat))
                {
                    landDestiny.Positionables.Add(entity);
                    landOrigin.Positionables.Remove(entity);
                }
                else throw new Exception($"{entity} ({entity.HabitatName}) no es compatible con el tipo de terreno {landDestiny}");
            }

           
        }


    }
}

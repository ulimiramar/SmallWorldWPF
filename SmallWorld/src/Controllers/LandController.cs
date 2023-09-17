using SmallWorld.src.Interfaces;
using SmallWorld.src.Model.Terrain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWorld.src.Controllers
{
    internal class LandController
    {
        private static LandController instance;
        private readonly List<Land> Lands = new List<Land>();
        private LandController() { }
        public static LandController GetInstance()
        {
            if (instance == null)
            {
                instance = new LandController();
            }
            return instance;
        }
        public void AddLand(ITerrainType terrainType)
        {
            Land LandToAdd = new Land(terrainType);
            Lands.Add(LandToAdd);
        }
        public List<Land> getLands()
        {
            return Lands;
        }
        public void Delete(Land land)
        {
            Lands.Remove(land);
        }
        public void Update(Land landToModify, Land landModified)
        {

            int index = Lands.FindIndex(e => e == landToModify);

            if (index != -1)
            {
                Lands[index] = landModified;

            }
        }
        
    }
}

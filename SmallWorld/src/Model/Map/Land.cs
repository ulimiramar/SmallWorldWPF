using SmallWorld.src.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWorld.src.Model.Terrain
{
    internal class Land
    {
        private static int lastId = 0;
        private ITerrainType terrainType;
        private List<Land> borderingLands;

        public int Id { get; private set; }
        internal ITerrainType TerrainType { get => terrainType; set => terrainType = value; }
        public string TerrainTypeName { get => terrainType.ToString(); }
        internal List<Land> BorderingLands { get => borderingLands; set => borderingLands = value; }
        public string BorderingLandsIds
        {
            get
            {
                string borderingLandsIds = "";
                foreach (var b in BorderingLands)
                {
                    borderingLandsIds = string.Join(", ", BorderingLands);
                }
                return borderingLandsIds;
            }
        }

        public Land(ITerrainType terrainType)
        {
            lastId++;
            Id = lastId;
            TerrainType = terrainType;
        }
        public Land() { }
    }
}

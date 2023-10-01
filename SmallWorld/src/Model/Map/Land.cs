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
        private List<Land> borderingLands = new List<Land>();
        private List<IPositionable> positionables;

        #region Properties
        public int Id { get; private set; }
        internal ITerrainType TerrainType { get => terrainType; set => terrainType = value; }
        public string TerrainTypeName { get => terrainType.ToString(); }
        internal List<Land> BorderingLands { get => borderingLands; set => borderingLands = value; }
        internal List<IPositionable> Positionables { get => positionables; set => positionables = value; }
        
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

        #endregion

        public Land(ITerrainType terrainType)
        {
            lastId++;
            Id = lastId;
            TerrainType = terrainType;
            Positionables = new List<IPositionable>();
        }
        public Land() { }
        public override string ToString()
        {
            return $"Id: {Id} , tipo: {TerrainType}";
        }
    }
}

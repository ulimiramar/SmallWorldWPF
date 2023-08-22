using SmallWorld.src.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWorld.src.Model.Map
{
    internal class Terrain
    {
        private int Id;
        private ITerrain terrainType;
        private List<Entity>Entities=new List<Entity>();

        internal ITerrain TerrainType { get => terrainType; set => terrainType = value; }

        //private Point Coordinates;

        public Terrain(int id, ITerrain terrainType)
        {
            Id = id;
            TerrainType = terrainType;
            //Coordinates = coordinates;
        }
        public Terrain(List<Entity> entities)
        {
            Entities = entities;
        }

    }
}

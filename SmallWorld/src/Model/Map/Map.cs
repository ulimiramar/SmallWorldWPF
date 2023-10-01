using SmallWorld.src.Interfaces;
using SmallWorld.src.Model.Terrain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWorld.src.Model.Map
{
    internal class Map
    {
        private static int lastId = 0;
        private List<Land> lands;
        public int Id { get; private set; }
        internal List<Land> Lands { get => lands; set => lands = value; }

        
        public Map(List<Land> lands)
        {
            lastId++;
            Id = lastId;
            Lands = lands;
        }
        public Map() 
        {
            lastId++;
            Id = lastId;
            Lands = new List<Land>();
        }
        public override string ToString()
        {
            return Id.ToString();
        }
    }
}

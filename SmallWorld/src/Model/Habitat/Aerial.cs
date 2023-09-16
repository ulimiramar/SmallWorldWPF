using SmallWorld.src.Interfaces;
using SmallWorld.src.Model.Dieta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWorld.src.Model.Habitat
{
    internal class Aerial : IHabitat
    {
        private string name = "Aéreo";
        public override bool Equals(object obj)
        {
            if (obj is Aerial other)
            {
                return name == other.name;
            }
            return false;
        }
        public override string ToString()
        {
            return name;
        }
        public override int GetHashCode()
        {
            return name.GetHashCode();
        }
    }
}

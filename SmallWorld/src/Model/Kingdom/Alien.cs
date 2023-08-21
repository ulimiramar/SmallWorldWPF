using SmallWorld.src.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWorld.src.Model.Reino
{
    internal class Alien : IKingdom
    {
        public string Name => "Alien";

        public string GetKingdomName()
        {
            return "Alien";
        }
        public override string ToString()
        {
            return "Alien";
        }
    }
}

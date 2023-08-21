using SmallWorld.src.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWorld.src.Model.Reino
{
    internal class Animal : IKingdom
    {
        public string Name => "Animal";
        public string GetKingdomName()
        {
            return "Animal";
        }
        public override string ToString()
        {
            return "Animal";
        }
    }
}
